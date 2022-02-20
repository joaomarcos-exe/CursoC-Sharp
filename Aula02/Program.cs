using System;

namespace Aula02//Namespace é uma forma de organização onde estar todos os objetos e as classes
{
    class Program
    {
        static void Main(string[] args)//Metodo principal e o string[] args são argumentos de entrada.
        {
            Console.WriteLine("CFB Cursos");
            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}
