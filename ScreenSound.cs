string greeting = "Hello! Welcome to Screen Sound App";

List<string> groups = ["Pink Floyd","Red Hot Chilli Peppers","Queen"];



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
  ShowGreeting();
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
  
  if (string.IsNullOrWhiteSpace(groupName))
{
    Console.WriteLine("Digite um nome válido.");
}
else if (groups.Contains(groupName))
{
    Console.WriteLine($"A banda {groupName} já está cadastrada.");
}
else
{
    groups.Add(groupName);
    Console.WriteLine($"A banda {groupName} foi cadastrada com sucesso.");
}
  Thread.Sleep(2000);
  Console.Clear();
  Menu();
};

void ListGroups()
{
  Console.Clear();
  Console.WriteLine("\n<-- Bandas registradas: -->");
  Console.WriteLine("");

  // for (int i = 0; i < groups.Count; i++)
  // {
  //   Console.WriteLine($"\n Nome da banda: {groups[i]}");
  // }

  foreach (string group in groups)
  {
    Console.WriteLine($"\nBanda: {group}");
  }
  Thread.Sleep(2000);
  Console.Clear();
  Menu();
}
  Menu();