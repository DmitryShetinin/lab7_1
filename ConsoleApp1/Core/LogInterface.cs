using System;
using System.Collections.Generic;
using System.Text;

namespace Shetinin
{
    interface LogInterface
    {
        LogInterface log(string str);
        LogInterface write();
    }
}