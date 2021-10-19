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
            Shetininlog.I().log("123");
            Shetininlog.I().log("123");
            Shetininlog.I().write();

        }
    }
}
