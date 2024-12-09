using PatternAdapter.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter.RealizationAdapter
{
    public class FrogAdapter : IDuck
    {
        private readonly IFrog _frog;

        public FrogAdapter(IFrog frog)
        {
            _frog = frog;
        }

        public void Quack()
        {
            _frog.Croak();
        }

        public void Fly()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                _frog.Jump();
            }
            Console.WriteLine("(Лягушка -> выполняет несколько длинных прыжков имитируя полет");
        }
    }
}
