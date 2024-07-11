using System;
using ExConjunto01.Entities;

namespace ExConjunto01
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            //Console.Write("Digite o caminho: ");
            string path = @"E:\Cursos\CSharp\ExConjunto01\ExConjunto01\Files\input.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                }
                Console.Write($"Total de usuários: {set.Count}");

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}