using ASCIIArtGenerator.Common;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Text;

namespace ASCIIArtGenerator
{
    public class AsciiArt : IAsciiArt
    {
        private Image<Rgba32>? ImageRgba32 { get; set; }

        public AsciiArt(string filePath)
        {
            try
            {
                using var inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var inputImage = Image.Load(inputStream);
                inputImage.Mutate(x => x.Resize(0, Helpers.maxSize));
                var imageRgba32 = inputImage.CloneAs<Rgba32>();
                ImageRgba32 = imageRgba32;
            }
            catch
            {
                Console.WriteLine("There was an error loading the image");
            }
        }

        public string Generate()
        {
            if (ImageRgba32 == null) return string.Empty;
            
            StringBuilder asciiBuilder = new(ImageRgba32.Width * ImageRgba32.Height);

            for (var h = 0; h < ImageRgba32.Height; h++)
            {
                for (var w = 0; w < ImageRgba32.Width; w++)
                {
                    var pixelColor = ImageRgba32[w, h];
                    var grayValue = (int)(pixelColor.R * 0.25 + pixelColor.G * 0.5 + pixelColor.B * 0.25);
                    var asciiChar = Helpers.asciiChars[grayValue * (Helpers.asciiChars.Length - 1) / 255];
                    asciiBuilder.Append(asciiChar);
                    asciiBuilder.Append(asciiChar);

                }
                asciiBuilder.AppendLine();
            }

            return asciiBuilder.ToString();
        }

        public void Print(string asciiArt) => Console.WriteLine(asciiArt);
    }
}
