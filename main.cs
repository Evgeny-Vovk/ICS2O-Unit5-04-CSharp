// Created by: Evgeny Vovk
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculate which movie rate can you watch
        int age;
        int day;

        // input
        Console.Write("This program tells you if you can pay student or regular price for museum admission: ");
        Console.WriteLine("");
        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter the number of the day you are coming: ");
        Console.Write("\n1 - Sunday \n2 - Monday \n3 - Tuesday \n4 - Wednesday \n5 - Thursday \n6 - Friday \n7 - Saturday");
        Console.Write("\nDay number: ");
        day = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if ((day == 3 || day == 5) && (age > 12 && age < 21))
        {
            Console.WriteLine("You are eligble for student pricing.");
        }
        else
        {
            Console.WriteLine("You must pay regular price.");
        }
        Console.WriteLine("\nDone.");
    }
}