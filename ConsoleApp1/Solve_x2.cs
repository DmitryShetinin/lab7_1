using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solve_x2 : Solve_x1
    {
        protected float disc(float a, float b, float c)
        {
            return b * b - (4 * a * c);
        }

        public List<float> solve_x2(float a, float b, float c)
        {

            if (a == 0)
            {
                return solve_x1(b, c);
            }


            float D = disc(a, b, c);

            if (D < 0)
            {
                return null;
            }

            //list = new List<double>(2);
            if (D == 0)
                return X = new List<float>() { (-b) / (2 * a) };

            D = (float)Math.Sqrt(D);//-b/(2a) - D/(2a)
            //c = 
            return X = new List<float>() {
                (-b + D) / (2 * a),
                (-b - D) / (2 * a)
            };

        }
    }
}
