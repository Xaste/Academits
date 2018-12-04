using System.Drawing;
using System;

namespace ImageTest
{
    class Blurring
    {
        static void Main(string[] args)
        {
            Bitmap imageIn = new Bitmap("image.jpg");
            Bitmap imageOut = new Bitmap(imageIn);

            double[,] table = { { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 } };
            //double[,] table = { { 0.0, -1.0, 0.0 }, { -1.0, 5.0, -1.0 }, { 0.0, -1.0, 0.0 } };
            //double[,] table = { { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 }, { (double)1 / 9, (double)1 / 9, (double)1 / 9 } };

            int stepY = table.GetLength(0) / 2;
            int stepX = table.GetLength(1) / 2;

            for (int y = stepY; y < imageIn.Height - stepY; ++y)
            {
                for (int x = stepX; x < imageIn.Width - stepX; ++x)
                {
                    double pixelR = 0;
                    double pixelG = 0;
                    double pixelB = 0;

                    for (int i = -stepY; i < table.GetLength(0) - stepY; i++)
                    {
                        for (int j = -stepX; j < table.GetLength(1) - stepX; j++)
                        {
                            Color pixel = imageIn.GetPixel(x + j, y + i);
                            pixelR += pixel.R * table[stepY + i, stepX + j];
                            pixelG += pixel.G * table[stepY + i, stepX + j];
                            pixelB += pixel.B * table[stepY + i, stepX + j];
                        }
                    }

                    pixelR = Saturation(pixelR);
                    pixelG = Saturation(pixelG);
                    pixelB = Saturation(pixelB);

                    Color newColor = Color.FromArgb((int)Math.Round(pixelR), (int)Math.Round(pixelG), (int)Math.Round(pixelB));

                    imageOut.SetPixel(x, y, newColor);
                }
            }

            imageOut.Save("imageOut.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public static double Saturation(double x)
        {
            const int maxRgb = 255;

            if (x < 0 || x > maxRgb)
            {
                return (x < 0) ? 0 : maxRgb;
            }

            return x;
        }
    }
}
