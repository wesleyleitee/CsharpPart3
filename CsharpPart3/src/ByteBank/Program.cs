using ByteBank.Funcionarios;

Funcionario carlos = new Funcionario(1);

carlos.Nome = "Carlos";
carlos.CPF = "546.456.456-20";
carlos.Salario = 2000;

Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.GetBonificacao());
Console.ReadLine();