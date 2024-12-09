using PatternBridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBridge.Control
{
    public abstract class RemoteControl
    {
        protected IDevice _device;

        public abstract void PowerOn();

        public abstract void PowerOff();

        public int SetChannel()
        {
            int channel;
            while (true)
            {
                Console.Write("Введите номер канала (от 1 до 100): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out channel))
                {
                    
                    if (channel >= 1 && channel <= 100)
                    {
                        Console.WriteLine($"Телевизор -> переключен на канал {channel}");
                        return channel;  
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: номер канала должен быть от 1 до 100!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректные числа!");
                }
            }
        }
    }
}
