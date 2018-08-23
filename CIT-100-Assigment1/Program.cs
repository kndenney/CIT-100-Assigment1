using System;

public class Jedi
{
	public static void Main()
	{
	    string Name;
	        Name = "Obi Wan";
	    
	    
	    
	    

	        Console.WriteLine("I am going to slice you hahaahah");
	    Slice(Name);
	    
	    
	    
	    

        //Change the name of the Jedi and slice the enemy
	    Name = "Luke Skywalker";
	        Slice(Name);
	}
	
	
	
	
	
	
	public static void Slice(string Name) {
	    Console.WriteLine("You have been sliced by " + Name);
	}
}
