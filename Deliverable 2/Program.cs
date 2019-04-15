using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1, answer2;


            Console.WriteLine(" Hello Tommy,\n What are you in the mood for?\n Here are your options.\n1 Action\n2 Chilling \n3 Danger \n4 Good Food\nPlease select the number value of your choice. ");
            answer1 = Console.ReadLine();
            int.TryParse(answer1, out int option);

            while (!int.TryParse(answer1, out option) || option < 1 || option > 5)
            {
                Console.WriteLine("Invalid Selection!\n\nOnly numbers 1-4...");
                Console.WriteLine("What are you in the mood for?\n\nSelect 1 for Action\n\nSelect 2 for Chilling\n\n" +
                "Select 3 for Danger\n\nSelect 4 for Good Food");
                answer1 = Console.ReadLine();
                int.TryParse(answer1, out option);
            }

            Console.WriteLine("How many people are you bringing with you? ");
            answer2 = Console.ReadLine();
            int.TryParse(answer2, out int people);

            while (!int.TryParse(answer2, out people) || people < 0)
            {
                Console.WriteLine("Invalid Selection!\n\nNumbers only...");
                Console.WriteLine();
                Console.WriteLine("How many people are attending?");
                answer2 = Console.ReadLine();
                int.TryParse(answer2, out people);
            }


            if (option == 1)
            {
                if (people == 0)
                { Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing  and  travel in sneakers!"); }
                else if (people > 0 && people < 5)
                { Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing  and  travel in a sedan!"); }
                else if (people > 4 && people < 11)
                { Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing  and  travel in a volkswagen bus !"); }
                else if (people >= 11)
                { Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing  and  travel in an airplane !"); }

            }


            else if (option == 2)
            {
                if (people == 0)
                { Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in sneakers!"); }
                else if (people > 0 && people < 5)
                { Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and  travel in a sedan!"); }
                else if (people > 4 && people < 11)
                { Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and  travel in a volkswagen bus !"); }
                else if (people >= 11)
                { Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and  travel in an airplane !"); }
            }
            else if (option == 3)
            {
                if (people == 0)
                { Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in sneakers!"); }
                else if (people > 0 && people < 5)
                { Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a sedan!"); }
                else if (people > 4 && people < 11)
                { Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a volkswagen bus !"); }
                else if (people >= 11)
                { Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in an airplane !"); }

            }
            else if (option == 4)
            {
                if (people == 0)
                { Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in sneakers!"); }
                else if (people > 0 && people < 5)
                { Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a sedan!"); }
                else if (people > 4 && people < 11)
                { Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a volkswagen bus !"); }
                else if (people >= 11)
                { Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in an airplane !"); }
            }
            else
            {
                Console.WriteLine("Sorry, the input was not understood");
            }


            Console.WriteLine("Have fun! \nGoodbye");
            Console.Read();
        }


    }
}


