using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    class Arifmetika:Kalk_arifmetika
    {
        public double Qoshish(double a,double b)
        {
          return  base.Result(a +b);
        }
        public double Ayrish(double a, double b)
        {
            return base.Result(a - b);
        }
        public double Kopaytrish(double a, double b)
        {
            return base.Result(a * b);
        }
        public double Bolish(double a, double b)
        {
           return base.Result(a / b);
        }
        public double Kub()
        {
            return Math.Pow(result, 3);
        }
        public double Log()
        {
            return Math.Log(result);
        }
        public double Ildiz()
        {
            return Math.Sqrt(result);
        }
        public double Kvadrat()
        {
            return Math.Pow(result, 2);
        }
        public double Sin()
        {
            return Math.Sin(result);
        }
        public double Cos()
        {
            return Math.Cos(result);
        }
        public double Tg()
        {
            return Math.Tan(result);
        }
        public double Ctg()
        {
            return 1 / Math.Tan(result);
        }
    }
}
