// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// --- Entrada em balada ---
Console.WriteLine("Digite sua idade:");
int idadeBalada = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu sexo (M/F):");
string sexo = Console.ReadLine().ToUpper();

Console.WriteLine("Você possui ingresso? (true/false):");
bool ingresso = bool.Parse(Console.ReadLine());

if ((ingresso && idadeBalada >= 18) || (sexo == "F" && idadeBalada >= 18))
{
    Console.WriteLine("Pode entrar na balada!");
}
else
{
    Console.WriteLine("Não pode entrar na balada!");
}

Console.WriteLine("\n---");

// --- Desconto no cinema ---
Console.WriteLine("Digite sua idade:");
int idadeCinema = int.Parse(Console.ReadLine());

Console.WriteLine("Você é estudante? (true/false):");
bool estudante = bool.Parse(Console.ReadLine());

if (idadeCinema < 12 || estudante || idadeCinema > 60)
{
    Console.WriteLine("Paga meia entrada no cinema!");
}
else
{
    Console.WriteLine("Paga inteira no cinema!");
}

Console.WriteLine("\n---");

// --- Acesso ao jogo online ---
Console.WriteLine("Digite sua idade:");
int idadeJogo = int.Parse(Console.ReadLine());

Console.WriteLine("Você possui assinatura? (true/false):");
bool assinatura = bool.Parse(Console.ReadLine());

if ((assinatura && idadeJogo > 16) || (!assinatura && idadeJogo > 18))
{
    Console.WriteLine("Acesso permitido ao jogo!");
}
else
{
    Console.WriteLine("Acesso negado ao jogo!");
}

Console.WriteLine("\n---");

// --- Aprovado, Recuperação ou Reprovado ---
Console.WriteLine("Digite a primeira nota:");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else if (media >= 5)
{
    Console.WriteLine("Aluno em recuperação!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
