using System;
using System.Collections.Generic;
using System.Text;

namespace modificadorRef
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }
    }
}
