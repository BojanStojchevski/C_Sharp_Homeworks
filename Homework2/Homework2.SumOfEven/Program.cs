// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int sumOfEven = 0;

int[] integers = new int[6];

Console.WriteLine("Enter integer no.1:");

integers[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.2:");

integers[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.3:");
integers[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.4:");
integers[3] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.5:");
integers[4] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter integer no.6:");
integers[5] = int.Parse(Console.ReadLine());


foreach (int num  in  integers)
{
    if(num % 2  == 0)
    {
        sumOfEven += num;
    }
  Console.WriteLine(" The result is: " + sumOfEven);
}




