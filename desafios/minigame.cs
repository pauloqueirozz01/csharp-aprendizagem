/* 

Mini game com C# 

Chegou a hora de seguir todos os passos realizados durante os estudos e 
criar um jogo com os conhecimentos adquiridos.

Neste jogo, o programa gera um número aleatório entre ***1*** e ***100*** e 
o usuário deve adivinhar qual é esse número.
O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário
é maior ou menor do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir 
para justificar o uso do Loop do-while, devemos ver que a condição é que
-> o usuário ainda não acertou o número secreto.
-> enquanto ele não acertar, o programa vai permitir que ele efetue várias tentativas.
-> Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem 
indicando que o jogo acabou.

*/

// começamos declarando um número
// int secretNumber = 42;
Random random = new Random();
int secretNumber = random.Next(1, 100);
// Random aleatorio para gerar um número aleatório
// usamos random.Next(1, 100); para dizer o 

do
{
  Console.WriteLine("Digite um número entre 1 e 100.");
  int attempt = int.Parse(Console.ReadLine());

  if (attempt == secretNumber){
    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
  } else if (attempt < secretNumber)
  {
    Console.WriteLine("O número secreto é maior.");
  } else 
  {
    Console.WriteLine("O numero é menor.");
  }
} while (true);