using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
     * 
     * 
     * */
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        List<Delegate1> functions;
        string name;

        public ComposedMission(string name)
        {
            this.name = name;
            functions = new List<Delegate1>(); 
        }
        public ComposedMission Add(Delegate1 func)
        {
            functions.Add(func);
            return this;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Type
        {
            get
            {
                return ("Composed");
            }
        }
        public double Calculate(double d)
        {
            double result = d;
            foreach(var func in functions)
            {
                result = func(result);
            }
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
