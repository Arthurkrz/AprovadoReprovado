using System;

namespace AprovadoReprovado
{
    public class Notas
    {
        public string Nome;
        public double Media;
        public double CalcularMedia(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
