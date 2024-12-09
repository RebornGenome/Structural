using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter.Targets
{
    public class Frog : IFrog
    {
        public void Croak()
        {
            Console.WriteLine("Лягушка -> Квакает");
        }

        public void Jump()
        {
            Console.WriteLine("Лягушка -> Прыгает");
        }
    }
}
