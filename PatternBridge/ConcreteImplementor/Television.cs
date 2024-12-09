using PatternBridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.ConcreteImplementor
{
    public class Television : IDevice
    {
        public void PowerOn()
        {
            Console.WriteLine("Телевизор -> Включен");
        }

        public void PowerOff()
        {
            Console.WriteLine("Телевизор -> Выключен");
        }

        public void SetChannel(int channel)
        {
        }
    }
}
