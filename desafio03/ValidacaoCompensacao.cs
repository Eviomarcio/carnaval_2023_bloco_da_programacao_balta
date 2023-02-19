using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio03
{
    public static class ValidacaoCompensacao
    {
        public static string Validar(double correlacao)
        {
            if (correlacao <= 72)
                return "Vantagem em abastencer o tanque com alcool";
            return "vantagem em abasteccer o tanque com gasolina";
        }
        public static double CoefienteEconomino(double alcool, double gasolina)
               => alcool / gasolina;
    }
}