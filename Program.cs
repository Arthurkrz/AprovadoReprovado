﻿using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bem vindo ao teste de boletim!\n\n" +
                $"Insira, linha por linha, o nome do aluno e suas notas nos três trimestres:");
            string nome = Console.ReadLine();
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
                    Console.WriteLine($"Aluno - {a.Nome};\n\nSituação - APROVADO!");
                }
                else
                {
                    Console.WriteLine($"Aluno - {a.Nome};\n\nSituação - REPROVADO!\nNota em débito - {60 - mediaAluno:F2}");
                }
            }
            else
            {
                Console.WriteLine("Valores incorretos.");
            }
        }
    }
}