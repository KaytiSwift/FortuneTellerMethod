using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //User interface displays a title then asks the user questions regarding first name, last name, age, birth month, favorite color, and number of siblings
            Console.WriteLine("Fortune Teller");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birth month? (Please provide a numeric value 1 - 12)");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite color? (Please select from ROYGBIV. For help, enter \"help\"");
            string color = Console.ReadLine().ToLower();

            FortuneTeller fortuneTeller = new FortuneTeller(firstName, lastName, age, birthMonth, color, siblings);

            //displays the fortune to the user based on their answers
            Console.WriteLine("{0} {1} will retire in {2} with {3} in the bank, a vacation home in {4}, and a {5}.", fortuneTeller.GetFirstName, fortuneTeller.GetLastName, fortuneTeller.GetRetirement(), fortuneTeller.GetMoney(), fortuneTeller.GetVacationHome(), fortuneTeller.GetTransportation());
        }
    }
}
