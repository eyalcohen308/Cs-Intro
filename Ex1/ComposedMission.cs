using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
     * class that calculate complex calculations base on given double.
     * */
    public class ComposedMission : IMission
    {
        // event handler that sumup all the events that happened.
        public event EventHandler<double> OnCalculate;
        // list of function to calculate base on an input.
        List<Delegate1> functions;
        // name of specific instant object of the class.
        string name;
        
        // constructor only by name of object.
        public ComposedMission(string name)
        {
            this.name = name;
            functions = new List<Delegate1>(); 
        }

        /**
         * add functions to the list of functions to calculate.
         * the function return same type to manage multy functions on the same object.
         **/
        public ComposedMission Add(Delegate1 func)
        {
            functions.Add(func);
            return this;
        }
        /**
         * properties of name and type
         * */
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

        /**
         * calculate the functions one by one, one's output is another's input.
         * check if the event handler already initilize, if so add the result and the sender to it.
         * */
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
