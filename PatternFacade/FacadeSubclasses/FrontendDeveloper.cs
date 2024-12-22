using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade.FacadeSubclasses
{
    public class FrontendDeveloper
    {
        public void WriteFrontendCode()
        {
            Console.WriteLine("Frontend-Разработчик пишет Пользовательский код.");
        }

        public void OptimizeApplication()
        {
            Console.WriteLine("Frontend-Разработчик оптимизирует производительность приложения.\n");
        }
    }
}
