using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file.txt";
        string[] lines = File.ReadAllLines(filePath);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] words = lines[i].Split(' ');

            for (int j = 0; j < words.Length; j++)
            {
                char[] characters = words[j].ToCharArray();
                Array.Reverse(characters);
                words[j] = new string(characters);
            }

            lines[i] = string.Join(" ", words);
        }

        File.WriteAllLines(filePath, lines);
    }
}
