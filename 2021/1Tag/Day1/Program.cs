// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Stream stdIn = Console.OpenStandardInput();
using StreamReader sr = new(stdIn);
// string? line = null;
// while ((line = sr.ReadLine()) != null)
// {
//     Console.WriteLine(line);
// }
//
//or
//
// while (!sr.EndOfStream)
// {
//     string line = sr.ReadLine();
//     System.Console.WriteLine(line);
// }
//
// or
//Stream stdOut = Console.OpenStandardOutput();
//stdIn.CopyTo(stdOut);


string[] content = File.ReadAllLines("1input.txt");
// foreach(string line in content)
// {
//     System.Console.WriteLine(line);
// }

int[] intContent = Array.ConvertAll(content, int.Parse);
int counter = 0;
for(int i = 1; i < intContent.Length; i++)
{
    if(intContent[i] > intContent[i - 1])
    {
        counter++;
    }
}
System.Console.WriteLine(counter);