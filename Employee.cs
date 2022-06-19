using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamConsoleApp1
{
    internal class Employee: IPerson

    {     // Samuel Kiarie - 06/18/2022
        // properties of Employee class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        // methods of Employee class
        public void SayHello()
        {
            Console.WriteLine($"Hi! I'm the {Title} and my name is " + FirstName + " " + LastName);
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye from the" + "  " + Title + "\n");
        }

    }
}
