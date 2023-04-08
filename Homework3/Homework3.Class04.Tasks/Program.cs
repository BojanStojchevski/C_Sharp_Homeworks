// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

#region TASK 1

////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// TASK 1

// Take one string from the input and print its last 5 characters.

Console.WriteLine("Write one string:");
string word = Console.ReadLine();
string lastFiveChar = word.Substring(word.Length - 5);
Console.WriteLine(lastFiveChar);

#endregion

#region TASK 2
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// TASK 2

//Take a sentence as input and print its words.

Console.WriteLine("Write one sentence:");
string sentence = Console.ReadLine();

string[] words = sentence.Split();
foreach (string w in words)
{
    Console.WriteLine(w);
}

#endregion

#region TASK 3

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//// TASK 3
///
//Create a function that takes a number as input. This method should return the sum of the digits in the number.


Console.WriteLine("Write a double digit number:");
int number = int.Parse(Console.ReadLine());

static int sumOfnumber(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;

};

Console.WriteLine(sumOfnumber(number));
#endregion

#region TASK 4
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// TASK 4
/
  //    Make a method called AgeCalculator
  //- The method will have one input parameter, your birthday date
  //- The method should return your age
  //- Show the age of a user after he inputs a date


Console.Write("Enter your birth date year: ");
int birthayDate = int.Parse(Console.ReadLine());

if (birthayDate > 2023)
{
    Console.WriteLine("You can not be born after current year!");

}
int AgeCalculator( int birthayDate)
{
        int age = 0;
        int currentyear = DateTime.Now.Year;
        age = currentyear - birthayDate;
        return age;
}
Console.WriteLine(AgeCalculator(birthayDate));

#endregion