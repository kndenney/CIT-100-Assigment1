using System;
using System.Collections.Generic;
using System.Text;

namespace CIT_100_Assigment1
{
    public class Human
    {
        public string Name { get; set; }

        public int Strength { get; set; }

        //Public is the accessibility level of this class
        //That means this class and any other 'public' items in the class
        //can be accessed from other parts of the program.
        //Other options are private - which means that other parts of the program cannot
        //access the class and/or function or property.

        //Name is a property - it is a feature within the class
        //that describes something within the class.
        //Just like a person has a real name
        //Classes are meant to describe real world objects or hypothetical objects that may not exist in the real world
        //And everything in the class is used to that end

        //the shorthand { get; set; } code here
        //are accessors.
        //Meaning they are used to access and set the value for the Name of Person.
        //In other words - programatically they are short for this:
        /*public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }*/

        //As you can see the 'get' modifier retrieves whatever the value of this particular name
        //is
        //The 'set' accessor takes a value and assigns that value to the name of the person

        //So that if we did something like:
        //this.name = 'Kyle'
        //'value' is equal to 'Kyle' and therefore the name property is assigned the value
        //'Kyle'
        //by C# internally
        //The = symbol in C# is used for assignment.
        //To take one value and assign it to something else.
        //In this case the 'Name' property is assigned the value 'Kyle'.

    }
}
