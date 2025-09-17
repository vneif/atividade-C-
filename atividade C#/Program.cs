// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1. Soma de 3 notas e média
Console.WriteLine("Digite a primeira nota:");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("A média das notas é: " + media);

Console.WriteLine("\n---");

// 2. Temperatura Celsius -> Fahrenheit
Console.WriteLine("Digite a temperatura em Celsius:");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);

Console.WriteLine("\n---");

// 3. Área de Quadrado
Console.WriteLine("Digite o lado do quadrado:");
double lado = double.Parse(Console.ReadLine());

double areaQuadrado = lado * lado;
Console.WriteLine("A área do quadrado é: " + areaQuadrado);

Console.WriteLine("\n---");

// 4. Área de Triângulo
Console.WriteLine("Digite a base do triângulo:");
double baseT = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do triângulo:");
double alturaT = double.Parse(Console.ReadLine());

double areaTriangulo = (baseT * alturaT) / 2;
Console.WriteLine("A área do triângulo é: " + areaTriangulo);

Console.WriteLine("\n---");

// 5. Área do Círculo (Constante PI)
const double PI = 3.14159;
Console.WriteLine("Digite o raio do círculo:");
double raio = double.Parse(Console.ReadLine());

double areaCirculo = PI * raio * raio;
Console.WriteLine("A área do círculo é: " + areaCirculo);

Console.WriteLine("\n---");

// 6. Perímetro do Retângulo
Console.WriteLine("Digite a largura do retângulo:");
double largura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura do retângulo:");
double altura = double.Parse(Console.ReadLine());

double perimetro = 2 * (largura + altura);
Console.WriteLine("O perímetro do retângulo é: " + perimetro);
