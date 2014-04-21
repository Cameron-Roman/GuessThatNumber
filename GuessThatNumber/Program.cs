using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I am calling the function guess nummber
            GuessNumber();
            // Here I am making the console window stay open.
            Console.ReadKey();
        }
        //Here I am writing a new function called GuessNumber to guess a random number for the user.
        static void GuessNumber()
        {
            //Here I am declaring a variable called random that is generating a random number.
            var random = new Random();
            // Here I am declaring a variable called cpuNum that is selecting a number between 1 and 100.
            var cpuNum = random.Next(0,100);
            //Here i'm printing out a question to ask the user to guess a number between 1 and 100.
            Console.WriteLine("Guess a number between 1 and 100. What's your first guess?");
            var input = Console.ReadLine();
            var nowNum = Convert.ToInt32(input);
            var attempts = 0;
            var coldHot = nowNum;
            while (nowNum != cpuNum)
            {
                if (nowNum < cpuNum)
                {
                    Console.WriteLine("Not quite , you need to go a bit higher!");
                    
                    nowNum = Convert.ToInt32(input);
                    //adds a count to the attempts counter
                    attempts = attempts + 1;
                    coldHot = nowNum;
                    if (cpuNum - nowNum < 20)
                    {
                        Console.WriteLine("You're getting warm!");
                    }
                    if(cpuNum - nowNum > 60 )
                    {
                        Console.WriteLine("You're cold!");
                    }
                }
                //here I am creating an else if statement to 
                else if (nowNum > cpuNum)
                {
                    
                    Console.WriteLine("Nope! You're too high try again!");
                    //creates another blank line ready for user input
               
                    attempts = attempts + 1;
                    coldHot = nowNum;
                    if (cpuNum - nowNum < 20)
                    {
                        Console.WriteLine("You're getting warm!");
                    }
                    if (cpuNum - nowNum> 60)
                    {
                        Console.WriteLine("You're cold!");
                      
                        // Here I am taking an user input and converting  it from a string to an interger
                        
                   
                    }
                }

                input = Console.ReadLine();
                nowNum = Convert.ToInt32(input);
            } 
            // Here I am taking an user input and converting  it from a string to an interger
                        
            //Here I  print a confrimation of the number has been found
            Console.WriteLine("Yes! The number is: " + cpuNum);
            // Here I print a line telling you your attempts and giving the number of attempts.
            Console.WriteLine("Your Attempts" + attempts);
            //Here I print a line that asks if you would like to play again.
            Console.WriteLine("Would you like to play again?");
           
            var choice = Console.ReadLine();
            // This says that when asked if you would like to play again and the answer is yes whether lowercase or not will play again. 
            if (choice.ToLower() == "yes")
            {
                GuessNumber();
            }
        }
    }
}

                
            

           
