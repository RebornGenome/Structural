using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade.FacadeSubclasses
{
    public class BackendDeveloper
    {
        public void WriteBackendCode()
        {
            Console.WriteLine("Backend-Разработчик пишет Серверную часть Кода для приложения.");
        }

        public void SetupDatabase()
        {
            Console.WriteLine("Backend-Разработчик настраивает Базу данных.\n");
        }
    }
}
