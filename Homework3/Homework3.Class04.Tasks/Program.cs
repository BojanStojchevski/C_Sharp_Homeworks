// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// TASK 1


//Console.WriteLine("Write one string:");
//string word = Console.ReadLine();
//string lastFiveChar = word.Substring(word.Length - 5);
//Console.WriteLine(lastFiveChar);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// TASK 2

//Console.WriteLine("Write one sentence:");
//string sentence = Console.ReadLine();
//string[] words = sentence.Split();

//foreach(string word in words)
//{
//    Console.WriteLine(word);
//}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// TASK 3

//Console.WriteLine("Write a double digit number:");
//int number = int.Parse(Console.ReadLine());

//static int sumOfnumber(int number)
//{
//    int sum = 0;
//    while (number != 0)
//    {
//        sum = sum + number % 10;
//        number = number / 10;
//    }

//    return sum;
//}

//Console.WriteLine(sumOfnumber(number));


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// TASK 4
Console.Write("Enter your birth date year: ");
int birthayDate = int.Parse(Console.ReadLine());

if(birthayDate > 2023)
{
    Console.WriteLine("You can not be born after current year!");
    
}
 int AgeCalculator()
{
    int age = 0;
    int currentyear = DateTime.Now.Year;
    age = currentyear - birthayDate;
    return age;
}

Console.WriteLine(AgeCalculator());