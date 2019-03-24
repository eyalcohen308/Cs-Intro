using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Delegate1(double d);
    public class FunctionsContainer
    {

        private Dictionary<string, Delegate1> dic;
        public FunctionsContainer()
        {
            dic = new Dictionary<string, Delegate1>();
        }
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
        public List<string> getAllMissions()
        {
            return new List<string>(this.dic.Keys);
        }
    }
}
