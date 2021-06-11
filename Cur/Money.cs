using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cur
{
    class Money
    {
        public const double k = 0.05;
        public int i = 0;
        public double ru;
        public double dol;
        public double how_m;
        public string combo;
        public double rate;
        const double step = 30d;
        double dt = 1d / step;
        const double mu = 0.10d;
        const double sigma = 0.10d;

        public void update()
        {
            Random random = new Random();
            double A1 = random.NextDouble();
            double A2 = random.NextDouble();

            if ((combo == "Продать") && (dol > 0) && (dol - how_m > 0))
            {
                ru = ru + how_m * rate;
                
                dol = dol - how_m;
                

            }

            if ((combo == "Купить") && (ru > rate) && (ru - how_m * rate >= 0))
            {
                ru = ru - how_m * rate;
                
                dol = dol + how_m;
                

            }

            rate += mu * rate * dt + sigma * rate * Math.Sqrt(-2.0 * Math.Log(A1)) * Math.Sin(2.0 * Math.PI * A2) * Math.Sqrt(dt);
        }
    }
}
