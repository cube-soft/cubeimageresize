using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace cuberesize
{
    class ImageResizer
    {
        public Bitmap Image { get; protected set; }

        public ImageResizer(Bitmap origin)
        {
            if (origin != null)
                Image = new Bitmap(origin);
            else
                Image = new Bitmap(1, 1);
        }

        public void Resize(int width, int height, InterpolationMode mode = InterpolationMode.Bicubic)
        {
            Bitmap tmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(tmp);
            g.InterpolationMode = mode;
            g.DrawImage(Image, 0, 0, width, height);
            Image.Dispose();
            Image = tmp;
        }

        public void toMonochrome()
        {
            ColorMatrix cm = new ColorMatrix(new float[][] {
                new float[] {0.298912F, 0.298912F, 0.298912F, 0, 0},
                new float[] {0.586611F, 0.586611F, 0.586611F, 0, 0},
                new float[] {0.114478F, 0.114478F, 0.114478F, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ConvertImage(cm);
        }

        public void toSepia()
        {
            ColorMatrix cm = new ColorMatrix(new float[][] {
                new float[] {0.281328F, 0.234440F, 0.169969F, 0, 0},
                new float[] {0.552104F, 0.460087F, 0.333563F, 0, 0},
                new float[] {0.107744F, 0.089786F, 0.065095F, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ConvertImage(cm);
        }

        private void ConvertImage(ColorMatrix cm)
        {
            ImageAttributes ia = new ImageAttributes();
            Bitmap tmp = new Bitmap(Image.Size.Width, Image.Size.Height);
            Graphics graphics = Graphics.FromImage(tmp);

            ia.SetColorMatrix(cm);
            graphics.DrawImage(Image, new Rectangle(new Point(), Image.Size), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, ia);
            Image.Dispose();
            Image = tmp;
        }

        public void UpSaturation()
        {
            ConvertImage2(hsv =>
            {
                hsv[HSV.Saturation] += 0.25;
                return hsv;
            });
        }

        public void UpBrightness()
        {
            ConvertImage2(hsv =>
            {
                hsv[HSV.Value] += 0.25;
                return hsv;
            });
        }

        public void UpContrast()
        {
            double min = 1.0;
            double max = 0.0;

            ConvertImage2(hsv =>
            {
                min = Math.Min(min, hsv[HSV.Value]);
                max = Math.Max(max, hsv[HSV.Value]);
                return hsv;
            });
            ConvertImage2(hsv =>
            {
                hsv[HSV.Value] = (hsv[HSV.Value] - min) / (max - min);
                return hsv;
            });
        }

        private struct HSV {
            public const int Hue = 0;
            public const int Saturation = 1;
            public const int Value = 2;
        }

        delegate double[] HSVProceedPred(double[] hsv);

        private void ConvertImage2(HSVProceedPred pred)
        {
            using (Cubic.BitmapAccessor img = new Cubic.BitmapAccessor(Image))
            {
                for (int h = 0, imHeight = img.Height; h < imHeight; ++h)
                {
                    for (int w = 0, imWidth = img.Width; w < imWidth; ++w)
                    {
                        Color c = img.GetPixel(w, h);
                        double[] hsv = new double[3];

                        double max = Math.Max(Math.Max(c.R, c.G), c.B);
                        double min = Math.Min(Math.Min(c.R, c.G), c.B);

                        hsv[HSV.Value] = max / 255.0;

                        if (max == 0)
                            hsv[HSV.Saturation] = 0;
                        else
                            hsv[HSV.Saturation] = (max - min) / max;

                        if (hsv[HSV.Saturation] <= 0)
                            hsv[HSV.Hue] = -1;
                        else
                        {
                            if (max == c.R)
                                hsv[HSV.Hue] = 60 * (double)(c.G - c.B) / (max - min);
                            else if (max == c.G)
                                hsv[HSV.Hue] = 60 * (double)(c.B - c.R) / (max - min) + 120;
                            else
                                hsv[HSV.Hue] = 60 * (double)(c.R - c.G) / (max - min) + 240;

                            if (hsv[HSV.Hue] < 0)
                                hsv[HSV.Hue] += 360;
                        }

                        hsv = pred(hsv);

                        if (hsv[HSV.Saturation] < 0)
                            hsv[HSV.Saturation] = 0;
                        else if (hsv[HSV.Saturation] > 1.0)
                            hsv[HSV.Saturation] = 1.0;

                        if (hsv[HSV.Value] < 0)
                            hsv[HSV.Value] = 0;
                        else if (hsv[HSV.Value] > 1.0)
                            hsv[HSV.Value] = 1.0;

                        if (hsv[HSV.Hue] < 0 || 360 <= hsv[HSV.Hue])
                        {
                            int m = (int)(hsv[HSV.Value] * 255);
                            c = Color.FromArgb(c.A, m, m, m);
                        }
                        else
                        {
                            int Hi = (int)(hsv[HSV.Hue] / 60);
                            double F = hsv[HSV.Hue] / 60.0 - Hi;
                            int M = (int)((hsv[HSV.Value] * (1.0 - hsv[HSV.Saturation])) * 255);
                            int N = (int)((hsv[HSV.Value] * (1.0 - hsv[HSV.Saturation] * F)) * 255);
                            int K = (int)((hsv[HSV.Value] * (1.0 - hsv[HSV.Saturation] * (1.0 - F))) * 255);

                            switch (Hi)
                            {
                                case 0:
                                    c = Color.FromArgb(c.A, (int)(hsv[HSV.Value] * 255), K, M);
                                    break;
                                case 1:
                                    c = Color.FromArgb(c.A, N, (int)(hsv[HSV.Value] * 255), M);
                                    break;
                                case 2:
                                    c = Color.FromArgb(c.A, M, (int)(hsv[HSV.Value] * 255), K);
                                    break;
                                case 3:
                                    c = Color.FromArgb(c.A, M, N, (int)(hsv[HSV.Value] * 255));
                                    break;
                                case 4:
                                    c = Color.FromArgb(c.A, K, M, (int)(hsv[HSV.Value] * 255));
                                    break;
                                case 5:
                                    c = Color.FromArgb(c.A, (int)(hsv[HSV.Value] * 255), M, N);
                                    break;
                            }
                        }
                        img.SetPixel(w, h, c);
                    }
                }
            }
        }
    }
}
