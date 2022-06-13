using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina01
{
    class Program
    {
        public static void Main(String[] args)
        {
            PayRoll MyPayRoll = new PayRoll();
            Console.WriteLine("1.Ingrese su numero de Documento:");
            MyPayRoll.setnumberdocument(double.Parse(Console.ReadLine()));
            Console.WriteLine("\n2.Ingrese su primer nombre: ");
            MyPayRoll.setFirst((Console.ReadLine()));
            Console.WriteLine("\n3.Ingrese su apellido: ");
            MyPayRoll.setlast((Console.ReadLine()));
            Console.WriteLine("\n4.Ingrese su salario: ");
            MyPayRoll.setsalary(double.Parse(Console.ReadLine()));
            Console.WriteLine("\n5.Ingrese los dias que trabaja: ");
            MyPayRoll.setworked(double.Parse(Console.ReadLine()));





            


        }

    }
}