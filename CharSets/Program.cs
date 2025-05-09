using System;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                List<char> allChars = new List<char>();

                foreach (string filePath in args)
                {

                    if (!File.Exists(filePath))
                    {
                        Console.Error.WriteLine($"Erro: Ficheiro não encontrado: {filePath}");
                        return;
                    }

                    var lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        if (line.Length != 1)
                        {
                            Console.Error.WriteLine($"Erro: Linha inválida no ficheiro '{filePath}': \"{line}\"");
                            return;
                        }

                        allChars.Add(line[0]);
                    }
                }

                List<char> uniqueChars = new List<char>();
                foreach (char c in allChars)
                {
                    if (!uniqueChars.Contains(c))
                    {
                        uniqueChars.Add(c);
                    }
                }

                uniqueChars.Sort();

                foreach (char c in uniqueChars)
                {
                    Console.WriteLine(c);
                }
        }
    }
}
