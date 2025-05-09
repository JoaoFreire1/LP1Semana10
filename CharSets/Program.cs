using System;
using System.Collections.Generic;
using System.IO;

namespace SpeedType
{
    /// <summary>
    /// The Program class contains the entry point for the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// It initializes the game and displays the main menu to the player.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
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

                // Remove duplicados manualmente
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

                return;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Erro inesperado: {ex.Message}");
                return;
            }


        }
    }
}

