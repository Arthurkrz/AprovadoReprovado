using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira as 1ª nota (máximo de 30): ");
                dados.nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira as 2ª nota (máximo de 35): ");
                dados.nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira as 3ª nota (máximo de 35): ");
                dados.nota3 = int.Parse(Console.ReadLine());
                if (dados.nota1 <= 30 && dados.nota2 <= 35 && dados.nota3 <= 35)
                {
                    CalculadoraMedia.CalcularMedia(dados);
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
            }
        }
    }
}