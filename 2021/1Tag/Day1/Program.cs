using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Stream stdIn = Console.OpenStandardInput();
        // using StreamReader sr = new(stdIn);
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

        //Task1
        int[] intContent = Array.ConvertAll(content, int.Parse);
        int counter = 0;
        for (int i = 1; i < intContent.Length; i++)
        {
            if (intContent[i] > intContent[i - 1])
            {
                counter++;
            }
        }
        //Task2
        int counter2 = 0;
        for (int i = 2; i + 1 < intContent.Length; i++)
        {
            if (intContent[i - 1] + intContent[i] + intContent[i + 1] > intContent[i - 2] + intContent[i - 1] + intContent[i])
            {
                counter2++;
            }
        }
        Console.WriteLine(counter2);
        // 2 3 4 2 1 7
        // 0 1 2 3 4 5
        // 6
    }
}