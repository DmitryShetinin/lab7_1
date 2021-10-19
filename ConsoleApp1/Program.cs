using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shetinin
{
    class Program
    {

        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Введите 3 аргумента квадратного уравнения!");
            a = (float)Convert.ToDouble(Console.ReadLine());
            b = (float)Convert.ToDouble(Console.ReadLine());
            c = (float)Convert.ToDouble(Console.ReadLine());
            try
            {
                Shetininlog.I().log($"{a}x+{b}x^2+{c} = 0");
                Solve_x2 s1 = new Solve_x2();
                Shetininlog.I().log("Корни уравнения " + String.Join("; ", s1.solve_x2(a, b, c)));
            }
            catch (ShetiniException ex)
            {
                Shetininlog.I().log(ex.Message);
            }

            Shetininlog.I().write();
            Console.ReadLine();

        }
    }
}
