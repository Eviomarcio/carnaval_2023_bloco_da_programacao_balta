namespace desafio02
{
    public static class IMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static void ClassificaoImc(double imc)
        {
            if (imc < 16)
                Console.WriteLine("> Magreza Grau III");
            if (imc > 16 && imc < 16.99)
                Console.WriteLine("> Magreza Grau II");
            if (imc > 17 && imc < 18.49)
                Console.WriteLine("> Magreza Grau I");
            if (imc > 18.5 && imc < 24.99)
                Console.WriteLine("> Peso ideal");
            if (imc > 25 && imc < 29.99)
            {
                Console.WriteLine("> Sobrepeso");
                Console.WriteLine("> Risco: Aumentado");
            }
            if (imc > 30 && imc < 34.99)
            {
                Console.WriteLine("> Obesidade grau I");
                Console.WriteLine("> Risco: Moderado");
            }
            if (imc > 35 && imc < 40)
            {
                Console.WriteLine("> Obesidade grau II");
                Console.WriteLine("> Risco: Grave");
            }
            if (imc > 40)
            {
                Console.WriteLine("> Obesidade grau III");
                Console.WriteLine("> Risco: Muito Grave");
            }
        }
    }
}