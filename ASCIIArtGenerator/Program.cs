// See https://aka.ms/new-console-template for more information
using ASCIIArtGenerator;

var asciiArt = new AsciiArt("C:\\Users\\marta\\Downloads\\jazz.gif");
asciiArt.Print(asciiArt.Generate());

var ColorExtension = new ColorExtension();
ColorExtension.SetAsciiArt(asciiArt);
ColorExtension.Print(ColorExtension.Generate());
