using ExemploFundamentos.Common.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Leonardo";
pessoa.Idade = 22;

pessoa.Apresentar();

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliete");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             // Environment.Exit(0); Finaliza totalmente o programa
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");

// int soma = 0;
// int numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++; //numero = numero + 1;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// bool choveu = true;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else 
// {
//     Console.WriteLine("Entranda não liberada!");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
    
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// string a = "15-";

// int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// int a = 5;
// double b = a;

// int a = 5;
// long b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32((a));

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// Cast - Casting
// int a = Convert.ToInt32(null);
// int a = int.Parse(null);

// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5; // c = c + 5
// c -= 5; // c = c - 5
// c *= 5; // c = c * 5

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.90M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Leonardo";
// pessoa1.Idade = 22;

// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();
