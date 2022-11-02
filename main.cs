// Created by: Claire Bedrossian
// Created on: Oct 2022
//
// This program calculates the area of a right rectangular pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;
        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");

        Console.Write("Enter the length of the radius (cm): ");
        radius = Convert.ToSingle(Console.ReadLine());

        volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3.00);

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume.ToString("0.000") + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}