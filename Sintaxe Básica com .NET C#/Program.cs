using Sintaxe_Básica_com_.NET_C_.Models;

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

string apresentacao = "Olá, seja bem vindo!";

int quantidade = 1;
quantidade = 10;

double altura = 1.80;

decimal preco = 1.90M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Leonardo";
pessoa1.Idade = 22;

pessoa1.Apresentar();

Pessoa pessoaFisicaRepresentacao = new Pessoa();
