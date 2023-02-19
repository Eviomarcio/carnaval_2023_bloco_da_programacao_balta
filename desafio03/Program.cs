using desafio03;

Console.Clear();
Console.Write("Digite o valor da Gasolina: R$");
double gasolina = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do Álcool: R$");
double alcool = double.Parse(Console.ReadLine());

var correlacao = ValidacaoCompensacao.CoefienteEconomino(alcool, gasolina) * 100;

System.Console.WriteLine(correlacao.ToString("F2") + "%");

var mensagem = ValidacaoCompensacao.Validar(correlacao);

System.Console.WriteLine("Resultado: " + mensagem);


