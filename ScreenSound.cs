string greeting = "Hello! Welcome to Screen Sound App";

List<string> registeredGroups = new List<string>();



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
      RegisterGroup();
      break;
    case 2:
      ListGroups();
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
      break;
  }
}

void RegisterGroup()
{
  Console.Clear();
  Console.WriteLine("Registro de Bandas");
  Console.WriteLine("Digite o nome da banda que você quer registrar: ");
  string? groupName = Console.ReadLine();
  
  if (!string.IsNullOrWhiteSpace(groupName))
  {
    Console.WriteLine($"A banda {groupName} foi cadastrada com sucesso.");
    registeredGroups.Add(groupName);  
  } else if (registeredGroups.Contains(groupName))
  {
    Console.WriteLine($"A banda {groupName} já foi registrada.");
  } else  {
    Console.WriteLine("Digite um nome válido.");
  }
  
  Menu();
};

void ListGroups()
{
  Console.WriteLine("\n Bandas registradas:");
  for (int i = 0; i < registeredGroups.Count; i++)
  {
    Console.WriteLine($"\n Nome da banda: {registeredGroups[i]}");
  }
}

  ShowGreeting();
  Menu();
