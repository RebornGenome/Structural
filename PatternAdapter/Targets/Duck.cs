using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter.Targets
{
    public class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Утка -> Крякает");
        }

        public void Fly()
        {
            Console.WriteLine("Утка -> Летит");
        }
    }
}
