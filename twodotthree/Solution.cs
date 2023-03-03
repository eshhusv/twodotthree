using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodotthree
{
    internal class Solution
    {
        public double x;
        public double y;

        public Solution(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string isPointLies()
        {
            if (y >= 0 && y <= 2 - x * x) return "Лежит";
            else return "Не лежит";
        }
    }
}
