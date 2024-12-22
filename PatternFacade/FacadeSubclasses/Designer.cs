using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade.FacadeSubclasses
{
    public class Designer
    {
        public void CreateDesignApplication()
        {
            Console.WriteLine("Дизайнер разрабатывает макет Приложения.");
        }

        public void ColorPalette()
        {
            Console.WriteLine("Дизайнер выбирает Цветовую Палитру для Приложения.\n");
        }
    }
}
