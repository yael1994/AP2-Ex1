/// yael mohaban
/// 205379126
/// group 05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise_1
{
    public class FunctionsContainer
    {
        private Dictionary<string, Func<double, double>> pairsF = new Dictionary<string, Func<double, double>>();
        /// <summary>
        /// the function create a dictionary of string to function
        /// </summary>
        /// <param name="name"> the name of the string, is the name of the mission</param>
        /// <returns> no return</returns>
        public Func<double, double> this[string name]
        {
            get
            {
                if (!pairsF.ContainsKey(name))
                {
                    pairsF[name] = x => x;
                }
                return pairsF[name];

            }
            set => pairsF[name] = value;
        }

        /// <summary>
        /// the function create list of all the key in the dictionary
        /// </summary>
        /// <returns>list of key</returns>
        public IList<string> getAllMissions()
        {
            IList<string> key = pairsF.Keys.ToList();
            return key;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}

