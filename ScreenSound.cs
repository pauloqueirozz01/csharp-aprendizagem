string greeting = "Hello! Welcome to Screen Sound App";

void ShowGreeting()
{
  Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
  Console.WriteLine(greeting);
}

void Menu()
{
  Console.WriteLine("\nDigite 1 para registrar uma banda.");
  Console.WriteLine("\nDigite 2 para mostrar todas as bandas.");
  Console.WriteLine("\nDigite 3 para avaliar uma banda.");
  Console.WriteLine("\nDigite 4 para exibir a média de uma banda");
  Console.WriteLine("\nDigite 5 para sair do programa.");

  Console.WriteLine("\nDigite uma opção: ");
  string opcaoEscolhida = Console.ReadLine()!; 
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      Console.WriteLine();
      break;
    case 2:
      Console.WriteLine();
      break;
    case 3:
      Console.WriteLine();
      break;
    case 4:
      Console.WriteLine();
      break;
    case 5:
      Console.WriteLine();
      break;
    default:
      Console.WriteLine("Opção inválida");
  }

}

ShowGreeting();
Menu();