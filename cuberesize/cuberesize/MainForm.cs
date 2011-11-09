using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace cuberesize
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            combo_quality.SelectedIndex = 1;
            combo_filename.SelectedIndex = 0;
        }

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
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (text_filename.Text.Length == 0)
                {
                    MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Bitmap original;
            ImageResizer result;
            String filepath;

            try
            {
                filepath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                original = new Bitmap(filepath);
                result = new ImageResizer(original);

                // resize
                result.Resize((int)numeric_width.Value, (int)numeric_height.Value);

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

                ImageCodecInfo jpegEncoder = null;
                foreach (ImageCodecInfo enc in ImageCodecInfo.GetImageEncoders()) {
                    if(enc.FormatID == ImageFormat.Jpeg.Guid) {
                        jpegEncoder = enc;
                        break;
                    }
                }

                Int64 jpgqual = 0;

                if (radio_filesize.Checked)
                {
                    Int64 min = 0, max = 101;
                    for (int i = 0 ; i < 7 ; ++i )
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

                result.Image.Save(filepath, jpegEncoder, encParams);
            }
            catch (ArgumentException)
            {
                //MessageBox.Show(((string[])e.Data.GetData(DataFormats.FileDrop))[0] + " は有効な画像ファイルではありません。");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                    numeric_quality.Value = 100;
                    break;
                case 2:
                    numeric_quality.Value = 50;
                    break;
                case 3:
                    numeric_quality.Value = 0;
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
                case 100:
                    combo_quality.SelectedIndex = 1;
                    break;
                case 50:
                    combo_quality.SelectedIndex = 2;
                    break;
                case 0:
                    combo_quality.SelectedIndex = 3;
                    break;
            }
        }

        private class NullStream : System.IO.Stream
        {
            private long len;

            public NullStream()
            {
                len = 0;
            }

            public override bool CanRead
            {
                get { return false; }
            }

            public override bool CanSeek
            {
                get { return false; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public override void Flush()
            {
                return;
            }

            public override long Length
            {
                get { return len; }
            }

            public override long Position
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, System.IO.SeekOrigin origin)
            {
                throw new NotImplementedException();
            }

            public override void SetLength(long value)
            {
                throw new NotImplementedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                len += count;
            }
        }
    }
}
