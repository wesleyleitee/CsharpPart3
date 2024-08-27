using ByteBank.Funcionarios;

Funcionario carlos = new Funcionario();
carlos.Nome = "Carlos";
carlos.CPF = "546.456.456-20";
carlos.Salario = 2000;

Diretor roberta = new Diretor();
roberta.Nome = "Roberta";
roberta.CPF = "789.789.798-30";
roberta.Salario = 5000;



Console.WriteLine($"Nome: {carlos.Nome}");
Console.WriteLine($"Bonificação {carlos.GetBonificacao()}");

Console.WriteLine($"Nome: {roberta.Nome}");
Console.WriteLine($"Bonificação {roberta.GetBonificacao()}");

Console.ReadLine();