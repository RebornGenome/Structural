using PatternFacade.FacadeSubclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade
{
    public class Manager
    {
        private readonly BackendDeveloper _backendDeveloper;
        private readonly FrontendDeveloper _frontendDeveloper;
        private readonly Designer _designer;

        public Manager()
        {
            _backendDeveloper = new BackendDeveloper();
            _frontendDeveloper = new FrontendDeveloper();   
            _designer = new Designer();
        }

        public void CreateApplication()
        {
            Console.WriteLine("Менеджер -> Начинает процесс разработки приложения.\n");

            _designer.CreateDesignApplication();
            _designer.ColorPalette();

            _frontendDeveloper.WriteFrontendCode();
            _frontendDeveloper.OptimizeApplication();

            _backendDeveloper.WriteBackendCode();
            _backendDeveloper.SetupDatabase();

            Console.WriteLine("Процесс разработки Приложения -> Завершен.");
        }
    }
}
