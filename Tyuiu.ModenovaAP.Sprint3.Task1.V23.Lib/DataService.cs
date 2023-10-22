using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ModenovaAP.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries += Math.Pow(300.0 / (Math.Sin(value) + (Math.Pow(value, startValue))), startValue);
                startValue++;
            }

            return Math.Round(multSeries, 3);
        }
    }
}
