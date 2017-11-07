using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class CStep
    {
        public Step NextStep { get; set; }
        public Step PrevStep { get; set; }

        public CStep(Step NextStep_, Step PrevStep_)
        {
            NextStep = NextStep_;
            PrevStep = PrevStep_;
        }

        public CStep()
        {
            NextStep = new Step();
            PrevStep = new Step();
        }
    }
}
