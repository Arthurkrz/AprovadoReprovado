using System;
using System.Collections.Generic;
using System.Text;

namespace AprovadoReprovado
{
    public class Aluno
    {
        public string nome;
        public int n1;
        public int n2;
        public int n3;
        public Aluno(string nome, int nota1, int nota2, int nota3)
        {
            this.nome = nome;
            n1 = nota1;
            n2 = nota2;
            n3 = nota3;
        }
        public double CalculoMedia(int n1, int n2, int n3)
        {
            return ((30 * n1) + (35 * n2) + (35 * n3)) / 100;
        }
    }
}
