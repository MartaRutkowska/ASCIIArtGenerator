// See https://aka.ms/new-console-template for more information
using ASCIIArtGenerator;
using ASCIIArtGenerator.Common;
using ASCIIArtGenerator.Decorators;

if(args.Length != 2)
{
    Console.WriteLine(Helpers.ErroNoOfArguments);
}

var imagePath= args[0];
var asciiArt = new AsciiArt(imagePath);

if (args[1] == Helpers.blackWhite)
{
    asciiArt.Print(asciiArt.Generate());
}
else if (args[1] == Helpers.color)
{
    var ColorExtension = new ColorExtension();
    ColorExtension.SetAsciiArt(asciiArt);
    ColorExtension.Print(ColorExtension.Generate());
}
