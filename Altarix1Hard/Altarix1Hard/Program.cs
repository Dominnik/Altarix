using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altarix1Hard.Classes;

namespace Altarix1Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер курса (1 курс, 2 курс, 3 курс, 4 курс): ");
            string numCourse = Console.ReadLine();

            course cour = AutoFac.getInstance(numCourse);

            Console.Write("\r\n{0}: ", cour.Num());
            cour.Ans();
            Console.ReadKey();
        }
    }
}
