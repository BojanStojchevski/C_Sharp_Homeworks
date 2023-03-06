// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

Console.WriteLine("Input the First number:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Second number:");
b = int.Parse(Console.ReadLine());

(a, b) = (b, a);
Console.WriteLine("After Swapping:");
Console.WriteLine("First number:" + a);
Console.WriteLine("Second number:" + b);