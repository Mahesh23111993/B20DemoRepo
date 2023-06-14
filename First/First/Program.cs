// See https://aka.ms/new-console-template for more information
using First;
Console.WriteLine("Please enter first number");

int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter second number");
int b = int.Parse(Console.ReadLine());		

calculator c = new calculator();
c.Add(a,b);

Console.ReadLine();