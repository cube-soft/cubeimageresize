using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

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
        const string SETTING_ENABLE_RESIZE      = "enable_resize";
        const string SETTING_RESIZE_METHOD      = "resize_method";
        const string SETTING_ENABLE_QUALITY     = "enable_quality";
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
        const string SETTING_LIST_METHOD        = "list_method";
        #endregion

        /* ----------------------------------------------------------------- */
        /// 変数定義
        /* ----------------------------------------------------------------- */
        #region Variables
        Global.Setting.Setting _setting;
        SizeSelector.ItemInfo _presize = null;
        bool _isupdate = false;
        #endregion

        /* ----------------------------------------------------------------- */
        /// 初期化
        /* ----------------------------------------------------------------- */
        #region Initialize

        public MainForm()
        {
            InitializeComponent();
            _setting = new Global.Setting.Setting(ORGANIZATION_NAME, APPLICATION_NAME);
            this.FormClosed += (sender,e) => _setting.Dispose();

            // サイズに関する初期設定
            check_resize.Checked = _setting.GetBool(SETTING_ENABLE_RESIZE, true);
            panel_resize.Enabled = check_resize.Checked;
            numeric_width.Value = _setting.GetInt(SETTING_WIDTH, 640);
            numeric_height.Value = _setting.GetInt(SETTING_HEIGHT, 480);
            this.SetResizeMethod(_setting.GetInt(SETTING_RESIZE_METHOD, 1));

            // 画質に関する初期設定
            check_quality.Checked = _setting.GetBool(SETTING_ENABLE_QUALITY, false);
            panel_quality.Enabled = check_quality.Checked;
            if (_setting.GetBool(SETTING_IS_QUALITY, true))
                radio_quality.Checked = true;
            else
                radio_filesize.Checked = true;
            numeric_quality.Enabled = radio_quality.Checked;
            numeric_quality.Value = _setting.GetInt(SETTING_QUALITY, 90);
            combo_quality.Enabled = radio_quality.Checked;
            track_quality.Enabled = radio_quality.Checked;
            numeric_filesize.Enabled = radio_filesize.Checked;
            numeric_filesize.Value = _setting.GetInt(SETTING_FILESIZE, 40);

            // 画像エフェクトに関する初期設定
            check_brightness.Checked = _setting.GetBool(SETTING_BRIGHTNESS, false);
            check_saturation.Checked = _setting.GetBool(SETTING_SATURATION, false);
            check_contrast.Checked = _setting.GetBool(SETTING_CONTRAST, false);
            check_monochrome.Checked = _setting.GetBool(SETTING_MONOCHROME, false);
            check_sepia.Checked = _setting.GetBool(SETTING_SEPIA, false);

            // 保存方法に関する初期設定
            if (_setting.GetBool(SETTING_IS_FOLDER, false))
                radio_folder.Checked = true;
            else
                radio_filename.Checked = true;
            text_folder.Enabled = radio_folder.Checked;
            text_folder.Text = _setting.GetString(SETTING_FOLDER, "resize");
            text_filename.Enabled = radio_filename.Checked;
            text_filename.Text = _setting.GetString(SETTING_FILENAME, "-resize");
            combo_filename.Enabled = radio_filename.Checked;
            if (_setting.GetBool(SETTING_MODIFIER, false))
                combo_filename.SelectedIndex = 0;
            else
                combo_filename.SelectedIndex = 1;
            check_overwrite.Checked = _setting.GetBool(SETTING_OVERWRITE, true);

            var list = new List<SizeSelector.ItemInfo>();
            int num = _setting.GetInt(SETTING_LIST_NUM, 0);
            for (int i = 0; i < num; ++i)
            {
                SizeSelector.ItemInfo info = new SizeSelector.ItemInfo(
                    _setting.GetString(SETTING_LIST_ID + i, ""),
                    _setting.GetString(SETTING_LIST_CATEGORY + i, ""),
                    _setting.GetString(SETTING_LIST_NAME + i, ""),
                    _setting.GetInt(SETTING_LIST_WIDTH + i, 0),
                    _setting.GetInt(SETTING_LIST_HEIGHT + i, 0),
                    _setting.GetInt(SETTING_LIST_METHOD + i, 1));
                combo_size.Items.Add(info.name);
                list.Add(info);
            }
            combo_size.Tag = list;
            if (num != 0) {
                combo_size.SelectedIndex = 0;
            }
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// メイン（変換）処理
        /* ----------------------------------------------------------------- */
        #region Convert methods

        /* ----------------------------------------------------------------- */
        ///
        /// ProcessDirectory
        /// 
        /// <summary>
        /// 指定されたフォルダ内に存在する全ての画像ファイルに対して，
        /// 設定画面の内容に従って画像を変換する．
        /// </summary>
        /// 
        /* ----------------------------------------------------------------- */
        public bool ProcessDirectory(string dirpath)
        {
            foreach (string filepath in Directory.GetFiles(dirpath))
            {
                if (File.Exists(filepath))
                {
                    if (!ProcessImage(filepath)) return false;
                }
            }
            return true;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ProcessImage
        /// 
        /// <summary>
        /// 指定された画像ファイルに対して，設定画面の内容に従って
        /// 画像を変換する．
        /// </summary>
        /// 
        /* ----------------------------------------------------------------- */
        public bool ProcessImage(string filepath)
        {
            var tmpfile = "";

            try
            {
                var original = new Bitmap(filepath);
                var result = new ImageResizer(original);
                var dest = this.GetResizedPath(filepath);
                if (!Directory.Exists(Path.GetDirectoryName(dest)))
                    Directory.CreateDirectory(Path.GetDirectoryName(dest));

                // resize
                if (check_resize.Checked)
                {
                    var resized = this.GetResizedSize(original.Size);
                    result.Resize(resized.Width, resized.Height);
                }

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

                // 各種処理の関係で一時ファイルにいったん保存した後，指定された保存先パスに移動させる．
                do
                {
                    tmpfile = Path.GetDirectoryName(dest) + @"\" + Path.GetRandomFileName() + @"\" + Path.GetFileName(dest);
                } while (File.Exists(tmpfile));
                if (!Directory.Exists(Path.GetDirectoryName(tmpfile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(tmpfile));

                if (check_quality.Checked)
                    this.SaveWithJpegQuality(result.Image, tmpfile);
                else
                    result.Image.Save(tmpfile, ImageFormat.Jpeg);

                this.MoveFile(tmpfile, dest);
                Directory.Delete(Path.GetDirectoryName(tmpfile), true);
            }
            catch (OperationCanceledException /* err */)
            {
                if (tmpfile.Length > 0) Directory.Delete(Path.GetDirectoryName(tmpfile), true);
                throw;
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

        /* ----------------------------------------------------------------- */
        ///
        /// GetResizedSize
        /// 
        /// <summary>
        /// サイズ変更後の幅と高さを取得する．変更後の幅と高さは，設定画面
        /// の内容に従って変わる．指定可能なサイズ変更方法は以下の通り:
        /// 
        /// - radio_resize_force : 指定された幅x高さで強制的に変更する
        /// - radio_resize_aspect: 縦横比を維持して変更する
        /// - radio_resize_width : 指定された幅に合わせて変更する
        /// - radio_reisze_height: 指定された高さに合わせて変更する
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private Size GetResizedSize(Size original)
        {
            // resize
            var width = (int)numeric_width.Value;
            var height = (int)numeric_height.Value;

            if (radio_resize_aspect.Checked)
            {
                if (width / (double)original.Width < height / (double)original.Height)
                {
                    height = (int)(width * (original.Height / (double)original.Width));
                }
                else width = (int)(height * (original.Width / (double)original.Height));
            }
            else if (radio_resize_width.Checked)
            {
                height = (int)(original.Height * (width / (double)original.Width));
            }
            else if (radio_resize_height.Checked)
            {
                width = (int)(original.Width * (height / (double)original.Height));
            }

            return new Size(width, height);
        }

        /* ----------------------------------------------------------------- */
        ///
        /// GetResizedPath
        /// 
        /// <summary>
        /// 変換した画像の保存先パスを取得する．パスは設定画面の内容に
        /// 従って変わる．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private string GetResizedPath(string src)
        {
            if (radio_folder.Checked)
            {
                return Path.GetDirectoryName(src) + @"\" + text_folder.Text + @"\"
                     + Path.GetFileNameWithoutExtension(src) + @".jpg";
            }
            else if (combo_filename.SelectedIndex == 0)
            {
                return Path.GetDirectoryName(src) + @"\"
                     + text_filename.Text + Path.GetFileNameWithoutExtension(src) + @".jpg";
            }
            else
            {
                return Path.GetDirectoryName(src) + @"\"
                     + Path.GetFileNameWithoutExtension(src) + text_filename.Text + @".jpg";
            }

        }

        /* ----------------------------------------------------------------- */
        ///
        /// CreateRecentlyResizedItem
        /// 
        /// <summary>
        /// 現在のサイズ，およびサイズ変更メソッドの値が最近使用した設定
        /// 一覧のどれにも当てはまらない場合，「ユーザ設定」とした項目
        /// を作成する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void CreateRecentlyResizedItem()
        {
            var list = combo_size.Tag as List<SizeSelector.ItemInfo>;
            if (_presize != null || list == null) return;

            var width = (int)numeric_width.Value;
            var height = (int)numeric_height.Value;
            var method = this.GetResizeMethod();
            foreach (var item in list)
            {
                if (item.width == width && item.height == height && item.method == method) return;
            }

            // コンボボックスに表示する文字列
            var name = "ユーザ設定 (";
            if (method == 3) name += "任意の幅";
            else name += width.ToString();
            name += "×";
            if (method == 2) name += "任意の高さ";
            else name += height.ToString();
            name += ")";

            _presize = new SizeSelector.ItemInfo("user", "user", name, width, height, method);
        }

        /* ----------------------------------------------------------------- */
        ///
        /// SaveRecentlyResizedList
        /// 
        /// <summary>
        /// 最近に使用したリサイズ設定の一覧を保存する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void SaveRecentlyResizedList() {
            var list = combo_size.Tag as List<SizeSelector.ItemInfo>;
            if (list == null) return;

            if (_presize != null) {
                for (int i = 0; i < list.Count; ++i) {
                    if (list[i].id == _presize.id && list[i].category == _presize.category) {
                        list.RemoveAt(i);
                        combo_size.Items.RemoveAt(i);
                        break;
                    }
                }
                combo_size.Items.Insert(0, _presize.name);
                list.Insert(0, _presize);
                combo_size.SelectedIndex = 0;
            }
            else if (combo_size.SelectedIndex != 0)
            {
                // 現在，選択されている項目を最上段へ移動させる．
                var selected = list[combo_size.SelectedIndex];
                list.RemoveAt(combo_size.SelectedIndex);
                list.Insert(0, selected);
                combo_size.Items.RemoveAt(combo_size.SelectedIndex);
                combo_size.Items.Insert(0, selected.name);
                combo_size.SelectedIndex = 0;
            }

            int num = combo_size.Items.Count;
            _setting.SetInt(SETTING_LIST_NUM, num);
            for (int i = 0; i < num; ++i) {
                _setting.SetString(SETTING_LIST_ID + i, list[i].id);
                _setting.SetString(SETTING_LIST_CATEGORY + i, list[i].category);
                _setting.SetString(SETTING_LIST_NAME + i, list[i].name);
                _setting.SetInt(SETTING_LIST_WIDTH + i, list[i].width);
                _setting.SetInt(SETTING_LIST_HEIGHT + i, list[i].height);
                _setting.SetInt(SETTING_LIST_METHOD + i, list[i].method);
            }

            _presize = null;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Move
        ///
        /// <summary>
        /// ファイルを移動する．移動先に同名のファイルが存在する場合，
        /// 上書き確認用ダイアログを表示するかどうかは設定画面の内容に
        /// 従って決定する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void MoveFile(string src, string dest)
        {
            if (check_overwrite.Checked)
            {
                Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(src, dest, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs);

            }
            else System.IO.File.Move(src, dest);
        }

        /* ----------------------------------------------------------------- */
        ///
        /// SaveWithJpegQuality
        /// 
        /// <summary>
        /// JPEG の画質を指定して保存する．JPEG の画質は設定画面の内容に
        /// 従って決定する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void SaveWithJpegQuality(Image image, string dest)
        {
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

                    image.Save(ns, jpegEncoder, ep);

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

            image.Save(dest, jpegEncoder, encParams);
        }

        #endregion

        /* ----------------------------------------------------------------- */
        /// ドラッグ&ドロップしたときに実行されるハンドラ
        /* ----------------------------------------------------------------- */
        #region Event handlers about Drag & Drop

        private void label_image_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label_image_DragDrop(object sender, DragEventArgs e)
        {
            if (radio_folder.Checked)
            {
                if (text_folder.Text.Length == 0)
                {
                    MessageBox.Show("保存するフォルダ名を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (text_filename.Text.Length == 0)
                {
                    MessageBox.Show("ファイル名に付与するテキストを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            try
            {
                string[] filelist;
                filelist = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string filepath in filelist)
                {
                    if ((File.GetAttributes(filepath) & FileAttributes.Directory) == FileAttributes.Directory)
                        ProcessDirectory(filepath);
                    else
                        ProcessImage(filepath);
                }
            }
            catch (OperationCanceledException)
            {
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
            _setting.SetBool(SETTING_ENABLE_RESIZE, check_resize.Checked);
            _setting.SetInt(SETTING_WIDTH, (int)numeric_width.Value);
            _setting.SetInt(SETTING_HEIGHT, (int)numeric_height.Value);
            _setting.SetInt(SETTING_RESIZE_METHOD, this.GetResizeMethod());
            _setting.SetBool(SETTING_ENABLE_QUALITY, check_quality.Checked);
            _setting.SetBool(SETTING_IS_QUALITY, radio_quality.Checked);
            _setting.SetInt(SETTING_QUALITY, (int)numeric_quality.Value);
            _setting.SetInt(SETTING_FILESIZE, (int)numeric_filesize.Value);
            _setting.SetBool(SETTING_BRIGHTNESS, check_brightness.Checked);
            _setting.SetBool(SETTING_SATURATION, check_saturation.Checked);
            _setting.SetBool(SETTING_CONTRAST, check_contrast.Checked);
            _setting.SetBool(SETTING_MONOCHROME, check_monochrome.Checked);
            _setting.SetBool(SETTING_SEPIA, check_sepia.Checked);
            _setting.SetBool(SETTING_IS_FOLDER, radio_folder.Checked);
            _setting.SetString(SETTING_FOLDER, text_folder.Text);
            _setting.SetString(SETTING_FILENAME, text_filename.Text);
            _setting.SetBool(SETTING_MODIFIER, combo_filename.SelectedIndex == 0);
            _setting.SetBool(SETTING_OVERWRITE, check_overwrite.Checked);

            _isupdate = true;
            this.CreateRecentlyResizedItem();
            this.SaveRecentlyResizedList();
            _isupdate = false;

            MessageBox.Show(this, "現在の設定を保存しました。", "CubeImage Resize", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* ----------------------------------------------------------------- */
        /// button_cancel_Click
        /* ----------------------------------------------------------------- */
        private void button_cancel_Click(object sender, EventArgs e) {
            _isupdate = true;
            this.SaveRecentlyResizedList();
            _isupdate = false;

            this.Close();
        }

        /* ----------------------------------------------------------------- */
        ///
        /// button_size_Click
        ///
        /// <summary>
        /// アシスタント機能（「他の設定サイズより選ぶ」）を通じて画像
        /// サイズを設定する．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void button_size_Click(object sender, EventArgs e) {
            using (SizeSelector selector = new SizeSelector(SIZE_SELECTOR_LAYOUT_XML)) {
                if (selector.ShowDialog(this) == System.Windows.Forms.DialogResult.Cancel)
                    return;
                _isupdate = true;
                _presize = selector.SelectedItem;
                numeric_width.Value = _presize.width;
                numeric_height.Value = _presize.height;
                this.SetResizeMethod(_presize.method);
                this.SaveRecentlyResizedList();
                _isupdate = false;
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
            if (!_isupdate)
                _presize = null;
        }

        private void combo_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = combo_size.Tag as List<SizeSelector.ItemInfo>;
            if (list == null) return;

            var info = list[combo_size.SelectedIndex];
            numeric_width.Value = info.width;
            numeric_height.Value = info.height;
            this.SetResizeMethod(info.method);
        }

        private void check_resize_CheckedChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;
            if (control == null) return;
            this.panel_resize.Enabled = control.Checked;
        }

        private void check_quality_CheckedChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;
            if (control == null) return;
            this.panel_quality.Enabled = control.Checked;
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
