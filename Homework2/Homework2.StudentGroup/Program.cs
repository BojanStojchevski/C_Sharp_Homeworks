// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] studentsG1 = new string[]{ "Bojan", "Goran", "Stojan","Zoran","Vojdan"};

string[] studentsG2 = new string[] { "Ace", "Teo", "Leo", "Neo", "Jo" };


Console.WriteLine("Write number 1 or 2..");

int num; ;
num = Int32.Parse(Console.ReadLine());

    if (num == 1)
    {
    foreach (string g1 in studentsG1)
    {
    Console.WriteLine(g1);
    }
    }
    else if(num == 2)
    {
        foreach (string g2 in studentsG2)
    {
        Console.WriteLine(g2);
    }
}
else
{
    Console.WriteLine("You typed incorect number!");

}



    
    

    




//for (int i = 0; i < studentsG1.Length; i++)
//{
//    g1 += studentsG1[i];
//    //Console.WriteLine(g1);
//}
//int num = 1;
//num = int.Parse(Console.ReadLine(g1));


//studentsG2 = int.Parse(Console.ReadLine());

