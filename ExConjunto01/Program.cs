using System;

namespace ExConjunto01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Cursos\CSharp\ExConjunto01\ExConjunto01\Files\input.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}