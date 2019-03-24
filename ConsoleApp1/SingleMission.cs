using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        Delegate1 delegate1;
        string name;
        public SingleMission(Delegate1 delegate1, string name)
        {
            this.delegate1 = delegate1;
            this.name = name;
        }
        public double Calculate(double d)
        {
            double result = delegate1(d);
            OnCalculate?.Invoke(this, result);
            return result;
        }
        public String Name
        {
            get
            {
                return name;
            }
        }
        public String Type
        {
            get
            {
                return ("Single");
            }
        }
    }
}
