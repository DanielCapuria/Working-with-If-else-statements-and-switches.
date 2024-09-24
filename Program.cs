using System.Runtime.CompilerServices;

namespace SwitchProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your name.");
            string name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine($"Hello {name}, please enter the service you are interested in: 1.Marines, 2.Army, 3.Airforce, 4.Navy, or 5.Coast Guard.");
            //Find out which branch you would like to join
            //string milBranch = Console.ReadLine()?.Trim().ToUpper();
            string milBranch = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(milBranch))
            { Console.WriteLine("Invalid");

            }

            var selection = int.Parse(milBranch);

            if (selection <1 || selection >5)
            {
                Console.WriteLine("Wrong input: Exiting now");
                return;
            }

            if (selection == 1)
            {
                Console.WriteLine("Marines have Combat engineer, Infantry, or Machine gunner available");
            }

            if (selection == 2)
            {
                Console.WriteLine("The Army has Aviation, Infantry, and Human resources jobs available");
            }
            if (selection == 3)
            {
                Console.WriteLine("The Airforce has Loadmaster jobs available and CCT");
            }
            if (selection == 4)
            {
                Console.WriteLine("The Navy has Seabees and Gunnersmate available");
            }
            else if (selection == 5)
            {
                Console.WriteLine("Not sure what the Coast Guard has available");
                    }

            switch (selection)
            {
                case 1: Console.WriteLine("Marines is normally the infantry for the Navy");
                    break;
                    case 2: Console.WriteLine("The Army has the best rotary wing unit in all of the branches!");
                    break;
                    case 3: Console.WriteLine("The Airforce has a great quality of life!");
                    break;
                case 4: Console.WriteLine("The United States has the largest Navy in the world!");
                    break;
                    case 5: Console.WriteLine("The Coast Guard branch doesn't belong to the Defense Department, but rather to the Department of Homeland Security.");
                    break;
            }


            






            //string milBranch = Console.ReadLine() ?? string.Empty;

          

            //if (string.IsNullOrWhiteSpace( milBranch ) )
            //{
            //    Console.WriteLine("Invalid Input: Please try again");
            //}

        }
    }
}
