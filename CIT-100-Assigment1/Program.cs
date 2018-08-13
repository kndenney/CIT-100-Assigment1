using System;

namespace CIT_100_Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human(); //Create a new instance of a new human in code
            h.Name = "Kyle"; //Assign the name of the human
            h.Strength = 50; //Assign the strength of the human

            Console.WriteLine(h.Name); //Read the Name of the Human
            Console.Read(); //Read allows you to Pause and hit "enter" to close the app
        }
    }
}
