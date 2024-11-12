namespace ASCIIArtGenerator.Common
{
    internal static class Helpers
    {
        public static readonly int maxSize = 80;
        public static string asciiChars = " .,:-=+*#%@";
        public static Dictionary<char, ConsoleColor> asciiColors =
            new() {
                { ' ', ConsoleColor.Gray },
                { '.', ConsoleColor.Blue },
                { ',', ConsoleColor.Blue },
                { ':', ConsoleColor.Green },
                { '-', ConsoleColor.Green },
                { '=', ConsoleColor.Red },
                { '+', ConsoleColor.Red},
                { '*', ConsoleColor.Yellow },
                { '#', ConsoleColor.Yellow },
                { '%', ConsoleColor.White },
                { '@', ConsoleColor.White } };
    }
}