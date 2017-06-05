using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altarix1Hard.Classes;


namespace Altarix1Hard
{
    class AutoFac
    {
        private AutoFac() { }

        public static course getInstance(string cour)
        {
            ContainerBuilder builder = new ContainerBuilder();
            switch (cour.ToString())
            {
                case "1 курс":
                    builder.RegisterType<_cour1>().As<course>();
                    break;
                case "2 курс":
                    builder.RegisterType<_cour2>().As<course>();
                    break;
                case "3 курс":
                    builder.RegisterType<_cour3>().As<course>();
                    break;
                case "4 курс":
                    builder.RegisterType<_cour4>().As<course>();
                    break;
                default:
                    builder.RegisterType<err>().As<course>();
                    break;
            }
            using (var container = builder.Build())
                return container.Resolve<course>();
        }
    }
}