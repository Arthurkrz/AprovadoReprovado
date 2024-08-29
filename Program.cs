using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao teste de boletim!\n \nInsira o nome do aluno:");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Nome do aluno: {nome}\n\nNota máxima do 1º trimestre é 30;\nNota máxima do 2º e 3º trimestre é 35.\n\nInsira, linha por linha, as notas do aluno dos três trimestres:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Aluno a = new Aluno(nome, n1, n2, n3);
            Console.Clear();
            if (a.n1 <= 30 && a.n2 <= 35 && a.n3 <= 35 && a.n1 >= 0 && a.n2 >= 0 && a.n3 >= 0)
            {
                double mediaAluno = a.CalculoMedia(a.n1, a.n2, a.n3);
                if (mediaAluno > 60)
                {
                    Console.WriteLine($"Aluno - {a.nome};\n\nSituação - APROVADO!");
                }
                else
                {
                    double restante = 60 - mediaAluno;
                    Console.WriteLine($"Aluno - {a.nome};\n\nSituação - REPROVADO!\nNota em débito - {restante}");
                }
            }
            else
            {
                Console.WriteLine("Valores incorretos.");
            }
        }
    }
}