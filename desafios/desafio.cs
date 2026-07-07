string curso = "Curso: Desenvolvimento Back-End com C# - Criando seu primeiro programa";
Console.WriteLine(curso);

Console.WriteLine("");
string nome = "Paulo";
string sobrenome = "Queiroz";
string nomeCompleto = nome + " " + sobrenome; 
Console.WriteLine($"Nome completo do Aluno: {nomeCompleto}");


List<string> instrutores = ["Daniel Portugal","Gui Lima"];

Console.WriteLine("Listando os instrutores do Curso:");
for (int i = 0; i < instrutores.Count(); i++){
  Console.WriteLine($"Instrutor: {instrutores[i]}");
}