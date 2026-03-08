
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace VehicleManagementSystem.Helpers
{
    public static class ImageHelper
    {
        public static Image Resize(Image img, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (var g = Graphics.FromImage(destImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);

                    g.DrawImage(img, destRect, 0, 0, img.Width, img.Height,
                        GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static byte[] ImageToBytes(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            try
            {
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            } catch
            {
                return null;
            }
        }
    }
}
