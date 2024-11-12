using System.Net.NetworkInformation;

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

        public static string blackWhite = "-bw";
        public static string color = "-c";

        public static string ErroNoOfArguments = "Please provide 2 arguments: filepath and color option -bw or -c";
        public static string ErrorFilePath = "Error: check if supplied filePath is correct and if you have READ access.";
    }
}