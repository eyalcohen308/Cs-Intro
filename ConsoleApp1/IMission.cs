using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
     * Interface of a mission. must have event handler and properties of name and type.
     * */
    public interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get;}
        String Type { get; }

        double Calculate(double value);
    }
}
