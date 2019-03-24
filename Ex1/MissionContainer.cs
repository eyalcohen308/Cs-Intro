using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /**
     * The mission container is a cllas that holds all the functions
     * that available for calculations.
     * the class override [] such that by given string it's bind it to a delegate function.
     * I implement the data structure to be a dictionary.
     * */
    public delegate double Delegate1(double d);
    public class FunctionsContainer
    {
        //dictionary of strings and functions.
        private Dictionary<string, Delegate1> dic;

        // defult constructor initialization, creating the dictionary. 
        public FunctionsContainer()
        {
            dic = new Dictionary<string, Delegate1>();
        }

        /**
         * override [], given string, return a delegate function from the dicronary,
         * if exits, otherwise return ID function.
         * */
      public Delegate1 this [string key]
        {
            get
            {
                if (!dic.ContainsKey(key))
                {
                    dic[key] = x => x;
                }
                return dic[key];
            }
            set
            {
                dic[key] = value;
            }
        }
        
        /**
         * function that return all missions name, by using built in dictonary function:
         * "Keys".
         * */
        public List<string> getAllMissions()
        {
            return new List<string>(this.dic.Keys);
        }
    }
}
