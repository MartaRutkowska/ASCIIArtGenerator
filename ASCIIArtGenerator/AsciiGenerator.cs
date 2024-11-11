using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASCIIArtGenerator
{
    internal static class AsciiGenerator
    {
        static string asciiChars = "@%#*+=-:,. ";
        static int maxSize = 80;

        public static StringBuilder Generate(string filePath)
        {
            using var inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            using var inputImage = Image.Load(inputStream);
            inputImage.Mutate(x => x.Resize(0, maxSize));
            using var imageRgba32 = inputImage.CloneAs<Rgba32>();

            StringBuilder asciiBuilder = new(imageRgba32.Width * imageRgba32.Height);

            for (var h = 0; h < imageRgba32.Height; h++)
            {
                for (var w = 0; w < imageRgba32.Width; w++)
                {
                    var pixelColor = imageRgba32[w, h];
                    var grayValue = (int)(pixelColor.R * 0.25 + pixelColor.G * 0.5 + pixelColor.B * 0.25);
                    var asciiChar = asciiChars[grayValue * (asciiChars.Length - 1) / 255];
                    asciiBuilder.Append(asciiChar);
                    asciiBuilder.Append(asciiChar);

                }
                asciiBuilder.AppendLine();
            }

            return asciiBuilder;
        }
    }
}
