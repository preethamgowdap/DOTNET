using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text you want to save:");
        string userInput = Console.ReadLine();

        
        string folderPath = @"C:\Users\gowpreet\Desktop\demo";
        
        
        string filePath = Path.Combine(folderPath, "testdocument.txt");

        
        Directory.CreateDirectory(folderPath);

        
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(userInput);
        }

        Console.WriteLine($"\nSuccess! Your text has been saved to:\n{filePath}");
    }
}
