using System;
using System.Collections.Generic;

namespace PingPong 
{
    public class Program
    {
    public static List<string> inputArray = new List<string> ();
     public static void Main()
    { 
        Console.WriteLine("Enter a number"); 
        
        string stringUserInput = Console.ReadLine(); 
        int intUserInput = int.Parse(stringUserInput);
    }
        public wow()
        {
        Console.WriteLine("Enter a number"); 
        string stringUserInput = Console.ReadLine(); 
        int intUserInput = int.Parse(stringUserInput);

            for(int i = 1; i <= intUserInput; i++)
            {
            if ( i % 15 == 0){
                inputArray.Add("Ping Pong");
                return "Ping Pong";
            }else if (  i % 5 == 0){
                inputArray.Add("Pong");
                return "Pong";
            }else if ( i % 3 == 0){
                inputArray.Add("Ping");
                return "Ping";
            } else 
                inputArray.Add(i.ToString()); 
                return inputArray;
        } 
        }    
        
    }
}
