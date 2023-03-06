// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1;
int num2;
int result;
string calculate;

Console.WriteLine("Enter the First number:");
num1 = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the Second number:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Operator:");
calculate = Console.ReadLine();

if (calculate == "+")
{
    result = num1 + num2;
    Console.WriteLine(result);
}
