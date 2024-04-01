using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas = new Notas();
            Console.WriteLine("Insira as 1ª nota (máximo de 30): ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira as 2ª nota (máximo de 35): ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira as 3ª nota (máximo de 35): ");
            int nota3 = int.Parse(Console.ReadLine());
            if (nota1 <= 30 && nota2 <= 35 && nota3 <= 35)
            {
                double mediafinal = notas.CalcularMedia(nota1, nota2, nota3);
                double restante = 60 - mediafinal;
                if (mediafinal >= 60)
                {
                    Console.WriteLine("APROVADO.");
                }
                else
                {
                    Console.WriteLine("REPROVADO.");
                    Console.WriteLine($"Restante necessário - {restante}");
                }
            }
            else
            {
                Console.WriteLine("Valores inválidos.");
            }
        }
    }
}