using System.Drawing;
using System;

namespace ImageTest
{
    class Grey
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("image.jpg");

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color pixel = image.GetPixel(x, y);

                    int newPixel = Convert.ToInt32(Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B));

                    Color newColor = Color.FromArgb(newPixel, newPixel, newPixel);

                    image.SetPixel(x, y, newColor);
                }
            }

            image.Save("out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
