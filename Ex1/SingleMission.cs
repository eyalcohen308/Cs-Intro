using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        /**
         * this class is a single mission that gets a function to do and it's name.
         * the class can calculate the delagete function base on input.
         **/
        public event EventHandler<double> OnCalculate;
        Delegate1 delegate1;
        string name;

        /**
         * constructor that get delegate and string name.
         **/
        public SingleMission(Delegate1 delegate1, string name)
        {
            this.delegate1 = delegate1;
            this.name = name;
        }
        
        /**
         * calculate the delegate based on double input.
         */
        public double Calculate(double d)
        {
            double result = delegate1(d);
            OnCalculate?.Invoke(this, result);
            return result;
        }

        /**
         * propeties of name and type.
         **/
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
