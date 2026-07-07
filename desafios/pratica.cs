/* 
A prática é um elemento essencial ao iniciar os estudos em programação, 
pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. 
Ao escrever código, resolver problemas e construir projetos reais, 
os iniciantes não apenas internalizam a sintaxe das linguagens de programação, 
mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. 
  Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".

Dica: Em caso de dúvidas para resolver os exercícios, recorra a Luri (Inteligência Artificial da Alura) ou a nossa comunidade no Fórum.
*/

double notaMedia = 0;
string nomeAluno = "";


// Resolvendo o primeiro desafio
if (notaMedia >= 5 )
{
  Console.WriteLine("Nota suficiente para Aprovação");
} else
{
  Console.WriteLine("Nota insuficiente para aprovação.");
}

/*
Desafio 2) 
  Criar uma variável de texto chamada nomeAluno e atribuir um nome a ela. 
  Exibir uma mensagem utilizando essa variável, como: "Olá, [nomeAluno]!".
*/
Console.WriteLine($"Olá, {nomeAluno}!");

/*
Desafio 3) 
  Criar uma função que receba um número inteiro como parâmetro e 
  retorne se ele é positivo, negativo ou zero.
  */

static void CheckNumber(int num)
{
  if (num >= 0)
  {
    Console.WriteLine($"{num} é positivo");
  } else if ( num == 0)
  {
    Console.WriteLine($"{num} é igual a zero.");
  } else
  {
    Console.WriteLine($"{num} é negativo.");
  }
}

CheckNumber(3);

// Podemos para este tipo de uso, capturar a entrada do usuario em outra variavel
Console.WriteLine("Digite um número");
int numeroDigitado = int.Parse(Console.ReadLine()!);
// Parse para converter de String para inteiro
CheckNumber(numeroDigitado);

/* Desafio 4) 
  Criar um programa que, dado a entrada de dados de um número n inteiro, 
  a partir do teclado, exibir a n-ésima posição de uma lista.
*/

Console.WriteLine("\n<-- Números e Lista -->");
static void CheckPosition()
{
  List<string> frutas = ["Maçã","Banana","Laranja","Uva","Tangerina","Mamão","Melão","Caqui", "Tomate","Melancia", "Limão"];
  for (int i = 0; i < frutas.Count; i++)
  {
    Console.WriteLine($"Item na lista: {frutas[i]}");
  }
  Console.WriteLine("\nQual item da lista você quer checar? Digite 0 a 10");
  Console.WriteLine("Digite o número do item:");

  string itemDigitado = Console.ReadLine()!;
  int numeroDoItem = int.Parse(itemDigitado);

  if (numeroDoItem >= 0 && numeroDoItem < frutas.Count)
  {
    Console.WriteLine($"\nNúmero escolhido: {numeroDoItem}");
    Console.WriteLine($"Item correspondente: {frutas[numeroDoItem]}");
  } else
  {
    Console.WriteLine($"\n{numeroDoItem} não está entre os números da lista.");
    Console.WriteLine("Número inválido, tente novamente.");
  }
  
}

CheckPosition();