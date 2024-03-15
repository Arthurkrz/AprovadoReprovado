using System;

namespace AprovadoReprovado
{
    public class CalculadoraMedia
    {
        public static double CalcularMedia(Dados dados)
        {
            double mediafinal = (dados.nota1 + dados.nota2 + dados.nota3) / 3;
            if (mediafinal >= 60)
            {
                Console.WriteLine("APROVADO.");
            }
            else
            {
                Console.WriteLine("REPROVADO.");
            }
            return mediafinal;
        }
    }
}