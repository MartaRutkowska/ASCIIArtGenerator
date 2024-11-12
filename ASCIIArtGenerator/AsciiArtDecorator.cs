using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Text;

namespace ASCIIArtGenerator
{
    internal abstract class AsciiArtDecorator : IAsciiArt
    {
        private IAsciiArt? AsciiArt;

        public void SetAsciiArt(IAsciiArt asciiArt)
            => AsciiArt = asciiArt;

        public virtual string Generate()
            => AsciiArt != null ? AsciiArt.Generate() : string.Empty;

        public virtual void Print(string asciiString)
            => AsciiArt?.Print(asciiString);
    }
}
