using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamConsoleApp1
{
    internal interface ILearner : IPerson
    {   // Samuel Kiarie -06/18/2022
        // properties of ILearner interface
        int TotalStudyTime { get; set; }

        // methods of ILearner interface
        void Study();

    }
}
