using ASCIIArtGenerator.Common;

namespace ASCIIArtGenerator.Decorators
{
    internal class ColorExtension : AsciiArtDecorator
    {
        public override void Print(string asciiArt)
        {
            for (int i = 0; i < asciiArt.Length; i = i + 2)
            {
                if (Helpers.asciiColors.TryGetValue(asciiArt[i], out var color))
                {
                    Console.ForegroundColor = color;
                    Console.Write(asciiArt[i]);
                    Console.Write(asciiArt[i]);
                }
                else Console.WriteLine();
            }
        }
    }
}
