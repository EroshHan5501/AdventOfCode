// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stream stdIn = Console.OpenStandardInput();
using StreamReader sr = new(stdIn);
// string? line = null;
// while ((line = sr.ReadLine()) != null)
// {
//     Console.WriteLine(line);
// }
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    System.Console.WriteLine(line);
}
// or
//Stream stdOut = Console.OpenStandardOutput();
//stdIn.CopyTo(stdOut);


// string[] content = File.ReadAllLines("../1input.txt");
// foreach(string l in content)
// {
//     System.Console.WriteLine(l);
// }