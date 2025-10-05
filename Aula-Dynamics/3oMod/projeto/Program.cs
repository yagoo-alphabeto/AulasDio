using projeto.Models;
using projeto.Models;
using projeto.Models;

// Pessoa p = new Pessoa();

// p.Nome = "Yagoo";
// p.Idade = 30;
// p.Apresentar();




// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1.85;

// decimal preco = 1.80M;

// bool condicao = true;

// DateTime dataAtual = DateTime.Now;


// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da quantidade: " + quantidade);
// Console.WriteLine("O valor da altra: " + altura);
// Console.WriteLine("O valor da preco: " + preco);
// Console.WriteLine("O valor da condicao: " + condicao);
// Console.WriteLine("Hoje é dia: " + dataAtual.ToString("dd/MM/yyyy"));



// int a = 10;
// int b = 20;
// int c = a + b;
// c += + 5;
// Console.WriteLine(c);



// int quantidadeEmEstoque = 10;

// int quantidadePedido = 4;

// bool possivelVenda = quantidadeEmEstoque >= quantidadePedido;

// if (quantidadePedido == 0)
//     {
//         Console.WriteLine("Venda Invalida");
//     }
// else if (possivelVenda)
//     {
//         Console.WriteLine("Venda pode ser Realizada");
//     }
// else
//     {
//         Console.WriteLine("Venda não pode ser Realizada");
//     }



// Console.WriteLine("Digite uma Letra");
// String letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"
//     )
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }




// Console.WriteLine("Digite uma Letra");
// String letra = Console.ReadLine();

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




// bool ehMaiorIdade = true;
// bool possuiAutorizacao = false;

// if (ehMaiorIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada Liberada")
// }
// else
// {
//     Console.WriteLine("Entrada não Liberada")
// }


// bool possuiPresensaMinima = true;
// double media = 7.5;

// if (possuiPresensaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado")
// }





// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);






// Trigonometria trig = new Trigonometria();

// trig.Seno(30);
// trig.Coseno(30);
// trig.Tangente(30);



// int n = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{n} x {contador} = {n * contador}");
// }


// int n = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{n} x {contador} = {n * contador}");
//     contador++;
// }






// int soma = 0 , numero = 0;

// do
// {
//     Console.WriteLine("Digite um Número(0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// }
// while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros é: {soma}");



// string opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua Opção");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4  Encerrar");
    
//     opcao = Console.ReadLine();

//     switch (opcao)
    
//     {
//         case "1":
//         Console.Write("Cadastro de Cliente");
//         break;

//         case "2":
//         Console.Write("Busca de Cliete");
//         break;

//         case "3":
//         Console.Write("Apagare Cliente");
//         break;

//         case "4":
//         Console.Write("Encerrar");
//         Environment.Exit(0);
//         break;

//         default:
//             Console.WriteLine("Opção Invalida");
//             break;
//     }
// }








// int[] arrayInt = new int[3];


// arrayInt[0] = 72;
// arrayInt[1] = 64;
// arrayInt[2] = 50;


// // Percorrendo o array com o for
// for(int contador = 0; contador < arrayInt.Length; contador++ )
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInt[contador]}");
// }


// // Percorrendo o array com o Foreach
// foreach(int valor in arrayInt)
// {
//     Console.WriteLine(valor);
// }






// List<string> lista1 = new List<string>();

// lista1.Add("SP");
// lista1.Add("MG");
// lista1.Add("RJ");
// lista1.Add("ES");

// for(int contador = 0; contador < lista1.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {lista1[contador]}");
// }

// int contadorforeach = 0;
// foreach(string item in lista1)
// {
//     Console.WriteLine($"Posição N° {contadorforeach} - {item}");
//     contadorforeach++;
// }






