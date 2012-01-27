using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace cuberesize
{
    public partial class MainForm : Form {
        /* ----------------------------------------------------------------- */
        /// 定数定義
        /* ----------------------------------------------------------------- */
        #region Contant variables
        const string ORGANIZATION_NAME          = "CubeSoft";
        const string APPLICATION_NAME           = "CubeImage Resize";
        const string SIZE_SELECTOR_LAYOUT_XML   = @".\assistant.xml";

        const string SETTING_WIDTH              = "width";
        const string SETTING_HEIGHT             = "height";
        const string SETTING_RESIZE_METHOD      = "resize_method";
        const string SETTING_IS_QUALITY         = "isquality";
        const string SETTING_QUALITY            = "quality";
        const string SETTING_FILESIZE           = "filesize";
        const string SETTING_BRIGHTNESS         = "brightness";
        const string SETTING_SATURATION         = "saturation";
        const string SETTING_CONTRAST           = "contrast";
        const string SETTING_MONOCHROME         = "monochrome";
        const string SETTING_SEPIA              = "sepia";
        const string SETTING_IS_FOLDER          = "isfolder";
        const string SETTING_FOLDER             = "folder";
        const string SETTING_FILENAME           = "filename";
        const string SETTING_MODIFIER           = "modifier";
        const string SETTING_OVERWRITE          = "overwrite";
        const string SETTING_LIST_NUM           = "list_num";
        const string SETTING_LIST_ID            = "list_id";
        const string SETTING_LIST_CATEGORY      = "list_category";
        const string SETTING_LIST_NAME          = "list_name";
        const string SETTING_LIST_WIDTH         = "list_width";
        const string SETTING_LIST_HEIGHT        = "list_height";
        #endregion

        /* ----------------------------------------------------------------- */
        /// 変数定義
        /* ----------------------------------------------------------------- */
        #region Variables
        Global.Setting.Setting setting;
        SizeSelector.ItemInfo presize = null;
        bool isupdate = false;
        #endregion

        /* ----------------------------------------------------------------- */
        /// 初期化
        /* ----------------------------------------------------------------- */
        #region Initialize

        public MainForm()
        {
            InitializeComponent();
            setting = new Global.Setting.Setting(ORGANIZATION_NAME, APPLICATION_NAME);
            this.FormClosed += (sender,e) => setting.Dispose();

            // サイズに関する初期設定
            numeric_width.Value = setting.GetInt(SETTING_WIDTH, 640);
            numeric_height.Value = setting.GetInt(SETTING_HEIGHT, 480);
            this.SetResizeMethod(setting.GetInt(SETTING_RESIZE_METHOD, 1));

            // 画質に関する初期設定
            if (setting.GetBool(SETTING_IS_QUALITY, true))
                radio_quality.Checked = true;
            else
                radio_filesize.Checked = true;
            numeric_quality.Enabled = radio_quality.Checked;
            numeric_quality.Value = setting.GetInt(SETTING_QUALITY, 90);
            combo_quality.Enabled = radio_quality.Checked;
            track_quality.Enabled = radio_quality.Checked;
            numeric_filesize.Enabled = radio_filesize.Checked;
            numeric_filesize.Value = setting.GetInt(SETTING_FILESIZE, 40);

            // 画像エフェクトに関する初期設定
            check_brightness.Checked = setting.GetBool(SETTING_BRIGHTNESS, false);
            check_saturation.Checked = setting.GetBool(SETTING_SATURATION, false);
            check_contrast.Checked = setting.GetBool(SETTING_CONTRAST, false);
            check_monochrome.Checked = setting.GetBool(SETTING_MONOCHROME, false);
            check_sepia.Checked = setting.GetBool(SETTING_SEPIA, false);

            // 保存方法に関する初期設定
            if (setting.GetBool(SETTING_IS_FOLDER, false))
                radio_folder.Checked = true;
            else
                radio_filename.Checked = true;
            text_folder.Enabled = radio_folder.Checked;
            text_folder.Text = setting.GetString(SETTING_FOLDER, "resize");
            text_filename.Enabled = radio_filename.Checked;
            text_filename.Text = setting.GetString(SETTING_FILENAME, "-resize");
            combo_filename.Enabled = radio_filename.Checked;
            if (setting.GetBool(SETTING_MODIFIER, false))
                combo_filename.SelectedIndex = 0;
            else
                combo_filename.SelectedIndex = 1;
            check_overwrite.Checked = setting.GetBool(SETTING_OVERWRITE, true);

            ArrayList list = new ArrayList();
            int num = setting.GetInt(SETTING_LIST_NUM, 0);
            for (int i = 0; i < num; ++i)
            {
                SizeSelector.ItemInfo info = new SizeSelector.ItemInfo(
                    setting.GetString(SETTING_LIST_ID + i, ""),
                    setting.GetString(SETTING_LIST_CATEGORY + i, ""),
                    setting.GetString(SETTING_LIST_NAME + i, ""),
                    setting.GetInt(SETTING_LIST_WIDTH + i, 0),
                    setting.GetInt(SETTING_LIST_HEIGHT + i, 0));
                combo_size.Items.Add(info.category + " - " + info.name);
                list.Add(info);
            }
            combo_size.Tag = list;
            if (num != 0)
                combo_size.SelectedIndex = 0;
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// メイン（変換）処理
        /* ----------------------------------------------------------------- */
        #region Convert methods

        private bool ProcessDirectory(string dirpath)
        {
            bool res = true;
            foreach (string filepath in Directory.GetFiles(dirpath))
            {
                if (File.Exists(filepath))
                    res = res && ProcessImage(filepath);
            }
            return res;
        }

        private bool ProcessImage(string filepath)
        {
            Bitmap original;
            ImageResizer result;
            string tmpfile;

            try
            {
                original = new Bitmap(filepath);
                result = new ImageResizer(original);

                // resize
                var width = (int)numeric_width.Value;
                var height = (int)numeric_height.Value;

                // サイズの変更方法にしたがって変更後サイズを決定する．
                // 指定可能なサイズ変更方法は以下の通り:
                //  radio_resize_force : 指定された幅x高さで強制的に変更する
                //  radio_resize_aspect: 縦横比を維持して変更する
                //  radio_resize_width : 指定された幅に合わせて変更する
                //  radio_reisze_height: 指定された高さに合わせて変更する
                if (radio_resize_aspect.Checked) {
                    if (width / (double)original.Width < height / (double)original.Height) {
                        height = (int)(width * (original.Height / (double)original.Width));
                    }
                    else width = (int)(height * (original.Width / (double)original.Height));
                }
                else if (radio_resize_width.Checked) {
                    height = (int)(original.Height * (width / (double)original.Width));
                }
                else if (radio_resize_height.Checked) {
                    width = (int)(original.Width * (height / (double)original.Height));
                }
                result.Resize(width, height);

                // UpBrightness
                if (check_brightness.Checked)
                    result.UpBrightness();

                // UpSaturation
                if (check_saturation.Checked)
                    result.UpSaturation();

                // UpContrast
                if (check_contrast.Checked)
                    result.UpContrast();

                // toMonochrome
                if (check_monochrome.Checked)
                    result.toMonochrome();

                // toSepia
                if (check_sepia.Checked)
                    result.toSepia();

                if (radio_folder.Checked)
                    filepath = Path.GetDirectoryName(filepath) + @"\" + text_folder.Text + @"\" + Path.GetFileNameWithoutExtension(filepath) + @".jpg";
                else if (combo_filename.SelectedIndex == 0)
                    filepath = Path.GetDirectoryName(filepath) + @"\" + text_filename.Text + Path.GetFileNameWithoutExtension(filepath) + @".jpg";
                else
                    filepath = Path.GetDirectoryName(filepath) + @"\" + Path.GetFileNameWithoutExtension(filepath) + text_filename.Text + @".jpg";

                Directory.CreateDirectory(Path.GetDirectoryName(filepath));
                do
                {
                    tmpfile = Path.GetDirectoryName(filepath) + @"\" + Path.GetRandomFileName() + @"\" + Path.GetFileName(filepath);
                } while (File.Exists(tmpfile));

                ImageCodecInfo jpegEncoder = null;
                foreach (ImageCodecInfo enc in ImageCodecInfo.GetImageEncoders())
                {
                    if (enc.FormatID == ImageFormat.Jpeg.Guid)
                    {
                        jpegEncoder = enc;
                        break;
                    }
                }

                Int64 jpgqual = 0;

                if (radio_filesize.Checked)
                {
                    Int64 min = 0, max = 101;
                    for (int i = 0; i < 7; ++i)
                    {
                        Int64 mid = (max + min) / 2;
                        NullStream ns = new NullStream();
                        EncoderParameters ep = new EncoderParameters(1);
                        EncoderParameter testqual = new EncoderParameter(Encoder.Quality, mid);
                        ep.Param[0] = testqual;

                        result.Image.Save(ns, jpegEncoder, ep);

                        if (ns.Length <= numeric_filesize.Value * 1024)
                            min = mid;
                        else
                            max = mid;
                    }
                    jpgqual = min;
                }
                else
                {
                    jpgqual = (Int64)numeric_quality.Value;
                }

                EncoderParameters encParams = new EncoderParameters(1);
                EncoderParameter quality = new EncoderParameter(Encoder.Quality, jpgqual);
                encParams.Param[0] = quality;

                if (!Directory.Exists(Path.GetDirectoryName(tmpfile))) Directory.CreateDirectory(Path.GetDirectoryName(tmpfile));
                result.Image.Save(tmpfile, jpegEncoder, encParams);
                if (check_overwrite.Checked) {
                    try {
                        Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(tmpfile, filepath, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs);
                    }
                    catch (OperationCanceledException /* err */) {
                        // 後で一時ディレクトリごと消す処理が走るので，ここでは何もしない．
                        // File.Delete(Path.GetDirectoryName(tmpfile));
                    }
                }
                else System.IO.File.Move(tmpfile, filepath);
                Directory.Delete(Path.GetDirectoryName(tmpfile), true);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// その他の内部用メソッド群
        /* ----------------------------------------------------------------- */
        #region Other utility methods

        /* ----------------------------------------------------------------- */
        ///
        /// GetResizeMethod
        ///
        /// <summary>
        /// ラジオボタンの選択状況からリサイズ方法を表すインデックスを取得
        /// する．ラジオボタンの内容と対応するインデックスは以下の通り：
        /// 
        /// - 指定したサイズで変換する: 0
        /// - 縦横比を維持する        : 1
        /// - 幅に合わせる            : 2
        /// - 高さに合わせる          : 3
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private int GetResizeMethod() {
            if (radio_resize_force.Checked)       return 0;
            else if (radio_resize_aspect.Checked) return 1;
            else if (radio_resize_width.Checked)  return 2;
            else if (radio_resize_height.Checked) return 3;
            
            return 0;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// SetResizeMethod
        ///
        /// <summary>
        /// 引数に指定されたインデックスに対応するラジオボタン（リサイズ
        /// 方法用）をチェック状態にする．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void SetResizeMethod(int index) {
            switch (index) {
                case 0: radio_resize_force.Checked = true; break;
                case 1: radio_resize_aspect.Checked = true; break;
                case 2: radio_resize_width.Checked = true; break;
                case 3: radio_resize_height.Checked = true; break;
                default: radio_resize_force.Checked = true; break;
            }
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// ドラッグ&ドロップしたときに実行されるハンドラ
        /* ----------------------------------------------------------------- */
        #region Event handlers about Drag & Drop

        private void label_image_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label_image_DragDrop(object sender, DragEventArgs e) {
            if (radio_folder.Checked) {
                if (text_folder.Text.Length == 0) {
                    MessageBox.Show("保存するフォルダ名を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else {
                if (text_filename.Text.Length == 0) {
                    MessageBox.Show("ファイル名に付与するテキストを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            try {
                string[] filelist;
                filelist = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string filepath in filelist) {
                    if ((File.GetAttributes(filepath) & FileAttributes.Directory) == FileAttributes.Directory)
                        ProcessDirectory(filepath);
                    else
                        ProcessImage(filepath);
                }
            }
            catch (OperationCanceledException) {
            }
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// 各種ボタンを押下した時に実行されるハンドラ
        /* ----------------------------------------------------------------- */
        #region Event handlers about buttons

        /* ----------------------------------------------------------------- */
        ///
        /// button_save_Click
        ///
        /// <summary>
        /// 現在の設定をレジストリに保存する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void button_save_Click(object sender, EventArgs e) {
            setting.SetInt(SETTING_WIDTH, (int)numeric_width.Value);
            setting.SetInt(SETTING_HEIGHT, (int)numeric_height.Value);
            setting.SetInt(SETTING_RESIZE_METHOD, this.GetResizeMethod());
            setting.SetBool(SETTING_IS_QUALITY, radio_quality.Checked);
            setting.SetInt(SETTING_QUALITY, (int)numeric_quality.Value);
            setting.SetInt(SETTING_FILESIZE, (int)numeric_filesize.Value);
            setting.SetBool(SETTING_BRIGHTNESS, check_brightness.Checked);
            setting.SetBool(SETTING_SATURATION, check_saturation.Checked);
            setting.SetBool(SETTING_CONTRAST, check_contrast.Checked);
            setting.SetBool(SETTING_MONOCHROME, check_monochrome.Checked);
            setting.SetBool(SETTING_SEPIA, check_sepia.Checked);
            setting.SetBool(SETTING_IS_FOLDER, radio_folder.Checked);
            setting.SetString(SETTING_FOLDER, text_folder.Text);
            setting.SetString(SETTING_FILENAME, text_filename.Text);
            setting.SetBool(SETTING_MODIFIER, combo_filename.SelectedIndex == 0);
            setting.SetBool(SETTING_OVERWRITE, check_overwrite.Checked);

            ArrayList list = (ArrayList)combo_size.Tag;
            if (presize != null) {
                for (int i = 0; i < list.Count; ++i) {
                    if (((SizeSelector.ItemInfo)list[i]).id == presize.id && ((SizeSelector.ItemInfo)list[i]).category == presize.category) {
                        list.RemoveAt(i);
                        combo_size.Items.RemoveAt(i);
                        break;
                    }
                }
                combo_size.Items.Insert(0, presize.name + " - " + presize.width + "×" + presize.height);
                list.Insert(0, presize);
            }

            int num = combo_size.Items.Count;
            setting.SetInt(SETTING_LIST_NUM, num);
            for (int i = 0; i < num; ++i) {
                SizeSelector.ItemInfo info = (SizeSelector.ItemInfo)list[i];
                setting.SetString(SETTING_LIST_ID + i, info.id);
                setting.SetString(SETTING_LIST_CATEGORY + i, info.category);
                setting.SetString(SETTING_LIST_NAME + i, info.name);
                setting.SetInt(SETTING_LIST_WIDTH + i, info.width);
                setting.SetInt(SETTING_LIST_HEIGHT + i, info.height);
            }

            presize = null;

            MessageBox.Show(this, "現在の設定を保存しました。", "CubeImage Resize", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* ----------------------------------------------------------------- */
        /// button_cancel_Click
        /* ----------------------------------------------------------------- */
        private void button_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        /* ----------------------------------------------------------------- */
        /// button_size_Click
        /* ----------------------------------------------------------------- */
        private void button_size_Click(object sender, EventArgs e) {
            using (SizeSelector selector = new SizeSelector(SIZE_SELECTOR_LAYOUT_XML)) {
                if (selector.ShowDialog(this) == System.Windows.Forms.DialogResult.Cancel)
                    return;
                isupdate = true;
                presize = selector.SelectedItem;
                numeric_width.Value = presize.width;
                numeric_height.Value = presize.height;
                isupdate = false;
            }
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// ラジオボタンのチェック状態が変更された時に実行されるハンドラ
        /* ----------------------------------------------------------------- */
        #region Event handlers about radio buttons' CheckedChanged

        /* ----------------------------------------------------------------- */
        ///
        /// radio_resize_method_CheckedChanged
        /// 
        /// <summary>
        /// リサイズ方法が変更された時に，設定の必要のない項目を無効に
        /// する．現在のところ，無効に設定する条件は以下の通り：
        /// 
        /// - 幅  : 高さに合わせる (index = 3) が指定されていると無効
        /// - 高さ: 幅に合わせる (index = 2) が指定されていると無効
        /// </summary>
        /// 
        /* ----------------------------------------------------------------- */
        private void radio_resize_method_CheckedChanged(object sender, EventArgs e) {
            var index = this.GetResizeMethod();
            numeric_width.Enabled = (index != 3);
            numeric_height.Enabled = (index != 2);
        }

        private void radio_folder_CheckedChanged(object sender, EventArgs e) {
            var control = sender as RadioButton;
            if (control == null) return;
            text_folder.Enabled = control.Checked;
        }

        private void radio_filename_CheckedChanged(object sender, EventArgs e) {
            var control = sender as RadioButton;
            if (control == null) return;
            text_filename.Enabled = control.Checked;
            combo_filename.Enabled = control.Checked;
        }

        private void radio_quality_CheckedChanged(object sender, EventArgs e) {
            var control = sender as RadioButton;
            if (control == null) return;
            numeric_quality.Enabled = control.Checked;
            combo_quality.Enabled = control.Checked;
            track_quality.Enabled = control.Checked;
        }

        private void radio_filesize_CheckedChanged(object sender, EventArgs e) {
            var control = sender as RadioButton;
            if (control == null) return;
            numeric_filesize.Enabled = control.Checked;
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// その他のイベントハンドラ
        /* ----------------------------------------------------------------- */
        #region Other event handlers

        private void track_quality_Scroll(object sender, EventArgs e)
        {
            numeric_quality.Value = track_quality.Value;
            combo_quality_select();
        }

        private void numeric_quality_ValueChanged(object sender, EventArgs e)
        {
            track_quality.Value = (int)numeric_quality.Value;
            combo_quality_select();
        }

        private void combo_quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combo_quality.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    numeric_quality.Value = 90;
                    break;
                case 2:
                    numeric_quality.Value = 70;
                    break;
                case 3:
                    numeric_quality.Value = 30;
                    break;
            }
        }

        private void combo_quality_select()
        {
            switch ((int)numeric_quality.Value)
            {
                default:
                    combo_quality.SelectedIndex = 0;
                    break;
                case 90:
                    combo_quality.SelectedIndex = 1;
                    break;
                case 70:
                    combo_quality.SelectedIndex = 2;
                    break;
                case 30:
                    combo_quality.SelectedIndex = 3;
                    break;
            }
        }

        private void numeric_wh_ValueChanged(object sender, EventArgs e)
        {
            if (!isupdate)
                presize = null;
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeSelector.ItemInfo info = (SizeSelector.ItemInfo)((ArrayList)combo_size.Tag)[combo_size.SelectedIndex];
            numeric_width.Value = info.width;
            numeric_height.Value = info.height;
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// NullStream
        /* ----------------------------------------------------------------- */
        #region NullStream Class

        private class NullStream : System.IO.Stream {
            private long len;

            public NullStream() {
                len = 0;
            }

            public override bool CanRead {
                get { return false; }
            }

            public override bool CanSeek {
                get { return false; }
            }

            public override bool CanWrite {
                get { return true; }
            }

            public override void Flush() {
                return;
            }

            public override long Length {
                get { return len; }
            }

            public override long Position {
                get {
                    throw new NotImplementedException();
                }
                set {
                    throw new NotImplementedException();
                }
            }

            public override int Read(byte[] buffer, int offset, int count) {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, System.IO.SeekOrigin origin) {
                throw new NotImplementedException();
            }

            public override void SetLength(long value) {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count) {
                len += count;
            }
        }

        #endregion
    }
}
