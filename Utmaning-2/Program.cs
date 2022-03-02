using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Utmaning_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int userinput = 0;
            int min = 1;
            int max = 100;

            Random random = new Random();
            int randomnumber = random.Next(min , max);

      
            Console.WriteLine("Hello, Guess a number between 1-100");
            while (randomnumber != userinput)
            {
                count++;
                
                userinput = (max + min) / 2;
                
                Console.WriteLine("Computer guessed: " + userinput);
                Thread.Sleep(200);
                if (userinput < randomnumber)
                {
                    Console.WriteLine("You guessed the number " + userinput + " Thats to low.. Guess higher.");
                    min = userinput;

                }
                else if (userinput > randomnumber)
                {
                    Console.WriteLine("You guessed the number " + userinput + " Thats to high.. Guess lower.");
                    max = userinput;

                }
                Thread.Sleep(200);
            }
            Console.WriteLine("You win!." + "It took you " + count + " times");
            Console.ReadLine();
        }      
    }
}
