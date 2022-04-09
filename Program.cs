// Cria variaveis em ponto flutuante 
double area,s, a, b, c;


Console.WriteLine("Digite os lados do triângulo desejado.");

Console.Write("Lado 1..:");
a = Convert.ToDouble (Console.ReadLine());

Console.Write("Lado 2..:");
b = Convert.ToDouble (Console.ReadLine());

Console.Write("Lado 3..:");
c = Convert.ToDouble (Console.ReadLine());

//Cálcula semiperimetro

s = (a + b + c) / 2;

//Cálcula a área do triângulo

area = Math.Sqrt (s * ( s - a)* (s - b) * (s - c));

//Exibe os resultados dos cálculos

Console.WriteLine($"Semiperímetro..:{s:N3}");
Console.WriteLine($"Área...........:{area:N3}");