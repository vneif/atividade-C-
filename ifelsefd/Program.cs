// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int idade;
Console.WriteLine("Digite sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char sexo;
Console.WriteLine("Digite seu sexo (M/F): ");
char.TryParse(Console.ReadLine().ToUpper(), out sexo);
// TryParse tenta converter o valor, se não conseguir,
// atribui o valor padrão do tipo (0 para int, '\0' para char, etc)

// Estrutura condicional if-else
Console.WriteLine("\n Verificação com if-else:");

// Exemplo 1: Verificação de maioridade
// OU || - pelo menos uma condição deve ser verdadeira
// && - todas as condições devem ser verdadeiras
//if (idade >= 18 || sexo == 'F') 
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Olá, você pode entrar na festa!");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Desculpe, você não pode entrar na festa.");
//}

bool temIngresso = true;
// Exemplo 02
if (temIngresso && idade >= 18 || sexo == 'F' && idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, você pode entrar na festa!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;