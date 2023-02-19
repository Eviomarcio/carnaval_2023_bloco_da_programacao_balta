using desafio02;

Console.WriteLine("Calcular o IMC (Índice de massa corporal de uma pessoa)");

Console.WriteLine("Informe sua altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe seu peso: ");
double peso = double.Parse(Console.ReadLine());

double imc = IMC.CalcularIMC(peso, altura);

Console.WriteLine("Seu IMC é: " + imc.ToString("N2"));

IMC.ClassificaoImc(imc);

System.Console.WriteLine("------------------------");
System.Console.WriteLine("fonte: OMS ( Organização Mundial da Saúde )");
