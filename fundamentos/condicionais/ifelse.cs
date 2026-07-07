
Console.WriteLine("Vamo treinar IF ELSE? sim / não");
string resposta = Console.ReadLine()!;
bool respostaLogica;

if (resposta == "sim")
{
  respostaLogica = true;
  Console.WriteLine($"Como a resposta foi {respostaLogica}, vou começar o treinamento.");
} else
{
  respostaLogica = false;
  Console.WriteLine($"Como a resposta foi {respostaLogica}, vamos treinar mesmo assim.");
}