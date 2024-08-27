using ByteBank;
using ByteBank.Funcionarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario carlos = new Funcionario();
carlos.Nome = "Carlos";
carlos.CPF = "546.456.456-20";
carlos.Salario = 2000;

gerenciador.Registrar(carlos);

Diretor roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.CPF = "789.789.798-30";
roberta.Salario = 5000;

gerenciador.Registrar(roberta);

Console.WriteLine($"Nome: {carlos.Nome}");
Console.WriteLine($"Bonificação {carlos.GetBonificacao()}");

Console.WriteLine($"Nome: {roberta.Nome}");
Console.WriteLine($"Bonificação {roberta.GetBonificacao()}");

Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

Console.ReadLine();