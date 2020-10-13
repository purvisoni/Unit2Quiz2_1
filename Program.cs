using System;
using System.Collections.Generic;
namespace IgnoreVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> stmt =new List<char>();
           
                Console.WriteLine("Enter any statement:");
                string userInput=Console.ReadLine();
            
                for(int i=0;i<userInput.Length;i++)
                {
                    if(userInput[i]=='a'|| userInput[i]=='e' || userInput[i]=='i' || userInput[i]=='o' || userInput[i]=='u')
                       continue;
                    
                   else
                    stmt.Add(userInput[i]);
                }
             
            for(int i=0;i<stmt.Count;i++)
            {
                    Console.Write(stmt[i]);
            }
       }
    }
}