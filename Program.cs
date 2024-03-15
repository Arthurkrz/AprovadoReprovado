using System;

namespace AprovadoReprovadoSOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota11;
            int nota21;
            int nota31;
            int nota12;
            int nota22;
            int nota32;
            int nota13;
            int nota23;
            int nota33;
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira a 1ª nota do 1º trimestre (máximo de 30): ");
                nota11 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 2ª nota do 1º trimestre (máximo de 30): ");
                nota21 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 3ª nota do 1º trimestre (máximo de 30): ");
                nota31 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 1ª nota do 2º trimestre (máximo de 35): ");
                nota12 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 2ª nota do 2º trimestre (máximo de 35): ");
                nota22 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 3ª nota do 2º trimestre (máximo de 35): ");
                nota32 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 1ª nota do 3º trimestre (máximo de 35): ");
                nota13 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 2ª nota do 3º trimestre (máximo de 35): ");
                nota23 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a 3ª nota do 3º trimestre (máximo de 35): ");
                nota33 = int.Parse(Console.ReadLine());

                int mediat1 = (nota11 + nota21 + nota31) / 3;
                int mediat2 = (nota12 + nota22 + nota32) / 3;
                int mediat3 = (nota13 + nota23 + nota33) / 3;

                if (mediat1 <= 30 && mediat2 <= 35 && mediat3 <= 35)
                {
                    double mediafinal = (mediat1 + mediat2 + mediat3) / 3;
                    if (mediafinal >= 60)
                    {
                        Console.WriteLine("APROVADO.");
                    }
                    else
                    {
                        Console.WriteLine("REPROVADO.");
                    }
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
            }
        }
    }
}