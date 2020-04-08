using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*This is a cat name generator where there are fixed Firstnames. 
  The user is expected to pick an initial letter for the Firstname 
  And enter a Surname for the cat which goes into a list. 
  Then, a full name is printed out for the cat.*/

namespace CatNameGenerator
{
    class Program
    {
        public static string UserChoice()
        {
            string[] catFNames = { "Gene", "Lucy", "Madam" };
            Console.WriteLine("Pick a FirstName initial from (G, L, M)");
            string userChoice = Console.ReadLine();

            if (userChoice == "G" || userChoice == "g")
            {
                return catFNames[0];
            }
            else if (userChoice == "L" || userChoice == "l")
            {
                return catFNames[1];
            }
            else if (userChoice == "M" || userChoice == "m")
            {
                return catFNames[2];
            }
            else
            {
                UserChoice();
                return "Error";
            }
        }
        public static void Main(string[] args)
        {
            string catFirstName;
            int randNum;

            catFirstName = UserChoice();

            //Generating dynamic pool of surnames
            List<string> catSNames = new List<string>();
            Console.WriteLine("Kindly input as many cat Surnames as you like:");
            string temp = Console.ReadLine();
            while (temp != "DONE") {
                catSNames.Add(temp);
                Console.WriteLine("Type another cat Surname or type \"DONE\" to finish");
                temp = Console.ReadLine();
            }

            //For randomly selecting Cat Surname
            Random rand = new Random();
            randNum = rand.Next(catSNames.Count);

            //For printing Cat Fullname
            Console.WriteLine("Your generated cat full name is: " + catFirstName + " " + catSNames[randNum]);
            Console.ReadLine();
        }
    }
}
