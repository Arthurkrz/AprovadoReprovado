using System;
using System.Collections.Generic;
using System.Text;

namespace AprovadoReprovado
{
    public class Aluno
    {
        private string _nome;
        public int n1;
        public int n2;
        public int n3;
        public string Nome
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nome))
                {
                    return "N/A";
                }
                return _nome;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
                else
                {
                    _nome = "N/A";
                }
            }
        }
        public Aluno(string nome, int nota1, int nota2, int nota3)  
        {
            Nome = nome;
            n1 = nota1;
            n2 = nota2;
            n3 = nota3;
        }
        public double CalculoMedia(int n1, int n2, int n3)
        {
            return ((30 * n1) + (35 * n2) + (35 * n3)) / 100.0;
        }
    }
}
