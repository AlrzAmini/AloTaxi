
using ImageMagick;

namespace AloTaxi.Application.Utilities.Convertors
{
    public static class ImageReSizer
    {
        public static void Resize(string currentFullFilePath,string savePath,int width,int height)
        {
            // Read from file
            using var image = new MagickImage(currentFullFilePath);
            var size = new MagickGeometry(width, height)
            {
                // Normally an image will be resized to fit inside the specified size.
                // This will resize the image to a fixed size without maintaining the aspect ratio.
                IgnoreAspectRatio = true,
            };

            image.Resize(size);

            // Save the result
            image.Write(savePath);
        }
    }
}
