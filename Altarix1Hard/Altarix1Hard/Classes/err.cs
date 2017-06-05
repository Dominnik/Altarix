using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altarix1Hard.Classes
{
    class err : course
    { 
        public string Num()
        {
            return "Ошибка";
        }
        public void Ans()
        {
            Console.WriteLine("Такого курса нет в базе");
        }
    }
}
