using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shetinin
{
    class Solve_x1
    {

        protected List<float> X;
        public List<float> solve_x1(float a, float b)
        {
            Shetininlog.I().log("Это линейное уравнение");
            if (a == 0)
                throw new ShetiniException("Уравнения не имеет решений");


            return X = new List<float>() { -b / a };
            //        X.Add(-b / a);

            //      return X; 


        }
    }
}
