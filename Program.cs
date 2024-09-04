using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao teste de boletim!\n\nInsira o nome do aluno:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Nome do aluno: {nome}\n\nInsira, linha por linha, as notas do aluno dos três trimestres:");
            int nota1 = int.Parse(Console.ReadLine());
            int nota2 = int.Parse(Console.ReadLine());
            int nota3 = int.Parse(Console.ReadLine());
            Aluno a = new Aluno(nome, nota1, nota2, nota3);
            Console.Clear();
            if (a.n1 <= 100 && a.n2 <= 100 && a.n3 <= 100 && a.n1 >= 0 && a.n2 >= 0 && a.n3 >= 0)
            {
                double mediaAluno = a.CalculoMedia(a.n1, a.n2, a.n3);
                if (mediaAluno > 60)
                {
                    Console.WriteLine($"Aluno - {a.nome};\n\nSituação - APROVADO!");
                }
                else
                {
                    Console.WriteLine($"Aluno - {a.nome};\n\nSituação - REPROVADO!\nNota em débito - {60 - mediaAluno:F2}");
                }
            }
            else
            {
                Console.WriteLine("Valores incorretos.");
            }
        }
    }
}