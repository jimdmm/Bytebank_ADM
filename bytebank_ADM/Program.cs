using bytebank_ADM.Funcionários;
using bytebank_ADM.Utilitario;

funcionario james = new funcionario();
james.Nome = "James Morrison";
james.Cpf = "123456789";
james.Salario = 2500;

Console.WriteLine(james.Nome);
Console.WriteLine(james.GetBonificacao());

diretor carlos = new diretor();
carlos.Nome = "Carlos Alberto";
carlos.Cpf = "987654321";
carlos.Salario = 5000;

Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.registrar(james);
gerenciador.registrar(carlos);

Console.WriteLine("Total de Bonificações: " + gerenciador.totalDeBonificacao);