﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x == 2) && ((y >= 5) && (y <= 6)) && (y == 13)) || ((x == 3) && ((y >= 3) && (y <= 7)) && (y == 13)) || ((x == 4) && ((y >= 3) && (y <= 7)) && (y == 12)) || ((x == 5) && ((y >= 3) && (y <= 7)) && ((y >= 9) && (y <= 10) && (y == 12)) || ((x == 6) && ((y >= 5) && (y <= 12))) || ((x == 7) && ((y >= 5) && (y <= 8))) || ((x == 8) && ((y >= 5) && (y <= 8))) || ((x == 9) && ((y >= 3) && (y <= 8))) || ((x == 10) && ((y >= 3) && (y <= 8))) || ((x == 11) && ((y >= 3) && (y <= 11))) || ((x == 12) && ((y >= 3) && (y <= 12))) || ((x == 13) && ((y >= 6) && (y <= 8)) && (y == 12))))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
