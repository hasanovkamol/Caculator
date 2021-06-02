using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public class Kalk_arifmetika
    {
        public double result { get; set; }
        public virtual double Result(double _result)
        {
            this.result = _result;
            return this.result;
        }
    }
}
