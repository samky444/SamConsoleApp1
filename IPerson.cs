using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamConsoleApp1
{
    public interface IPerson
    {      // Samuel Kiarie - 06/18/2022
        // properties of IPerson interface
       public string FirstName { get; set; }
        public string LastName { get; set; }


        // methods of IPerson interface
        public void SayHello();
        public void SayGoodbye();

    }
}
