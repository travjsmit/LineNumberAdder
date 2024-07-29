using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: Program.exe <inputFile> <outputFile>");
            return;
        }

        string inputFile = args[0];
        string outputFile = args[1];

        try
        {
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                int lineNumber = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{lineNumber}: {line}");
                    lineNumber++;
                }
            }

            Console.WriteLine($"File {inputFile} has been processed and saved as {outputFile}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
