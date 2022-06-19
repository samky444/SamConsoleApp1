using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamConsoleApp1
{ //  Samuel Kiarie - 06/18/2022
    public class Student : ILearner
    {
        // properties of Student class
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int TotalStudyTime { get; set; }

        // methods of Student class
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + FirstName + " " + LastName);
        }
                public void SayGoodbye()
        {
            Console.WriteLine("This is the study method of Student Class, Goodbye!");
        }

        public void Study()
        {
            Console.WriteLine("I have studied C# for " + TotalStudyTime + " hours.");
        }

    }
}
