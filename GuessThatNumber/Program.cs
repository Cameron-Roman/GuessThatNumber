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
            var turnNum = Convert.ToInt32(input);
            var attempts = 0;
            var coldHot = turnNum;
            while (turnNum != cpuNum)
            {
                if (turnNum < cpuNum)
                {
                    Console.WriteLine("Not quite , you need to go a bit higher!");
                     input = Console.ReadLine();
                    //takes user input and converts it from a string to an interger
                    nowNum = Convert.ToInt32(input);
                    //adds a count to the attempts counter
                    attempts = attempts + 1;
                    coldHot = nowNum;
                    if (cpuNum - nowNum < 20)
                    {
                        Console.WriteLine("You're getting warm!");
                    }
                    if(cpuNum - turnNum > 60 )
                    {
                        Console.WriteLine("You're cold!");
                    }
                }
                //here I am creating an else if statement to 
                else if (turnNum > cpuNum)
                {
                    //This will print a line that says you're too low and to try again
                    Console.WriteLine("Nope! You're too high try again!");
                    //creates another blank line ready for user input
                    input = Console.ReadLine();
                    // Here I am taking an user input and converting  it from a string to an interger
                    turnNum = Convert.ToInt32(input);
                    // This adds a count to the attempts counter
                    attempts = attempts + 1;
                    coldHot = turnNum;
                    if (cpuNum - turnNum < 20)
                    {
                        Console.WriteLine("You're getting warm!");
                    }
                    if (cpuNum - turnNum> 60)
                    {
                        Console.WriteLine("You're cold!");
                    }
                }
               
            }
            //This prints a confrimation of the number has been found
            Console.WriteLine("Yes! The number is: " + cpuNum);
            // This prints a line telling you your attempts and giving the number of attempts.
            Console.WriteLine("Your Attempts" + attempts);
            // This prints a line that asks if you would like to play again.
            Console.WriteLine("Would you like to play again?");
            //This takes the input choice and lets the user type in their choice.
            var choice = Console.ReadLine();
            // This says that 
            if (choice != "no")
            {
                GuessNumber();
            }
        }
    }
}

                
            

           

        }
    }
}
