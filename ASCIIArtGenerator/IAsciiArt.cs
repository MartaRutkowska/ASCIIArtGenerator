using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtGenerator
{
    internal interface IAsciiArt
    {
        string Generate();

        void Print(string stringBuilder);
    }
}
