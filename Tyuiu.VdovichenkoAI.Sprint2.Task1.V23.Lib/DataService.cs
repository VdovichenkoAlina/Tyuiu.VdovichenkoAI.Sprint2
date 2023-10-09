using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (b < c);
            res[1] = (c > d) & (a + 300 > b);
            res[2] = (d > c) || (b < a);
            res[3] = (a < b) && (c > d);
            res[4] = !res[0];
            res[5] = (d + 200 > c) ^ (d > a);
            return res;
        }
    }
}
