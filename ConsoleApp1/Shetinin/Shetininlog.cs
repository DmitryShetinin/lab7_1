using System;
using System.Collections.Generic;
using System.Text;

namespace Shetinin
{
    class Shetininlog : LogAbstract, LogInterface
    {
        private static Shetininlog instance;
        List<string> ListArr = new List<string>();
        public static Shetininlog I()
        {
            if (instance == null)
                instance = new Shetininlog();
            return instance;
        }

        public LogInterface log(string str)
        {
            ListArr.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(ListArr.ToArray());
            return this;
        }
    }
}