/// yael mohaban
/// 205379126
/// group 05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise_1
{
    /// <summary>
    /// the class every time cunculate one mission
    /// </summary>
    class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get; private set; }
        public string Type { get; private set; }
        public delegate double singleDel(double val);
        private singleDel missionS;
        
        /// <summary>
        /// the constructor of the class
        /// </summary>
        /// <param name="func">the function that the mission get</param>
        /// <param name="name">the name of the mission</param>
        public SingleMission(Func<double, double> func, string name)
        {
            this.missionS = new singleDel(func);
            this.Name = name;
            this.Type = "Single";

        }
        /// <summary>
        /// the metod calculate the function and return is value
        /// </summary>
        /// <param name="value"> the value that the function calculate</param>
        /// <returns>the return of the function</returns>
        public double Calculate(double value)
        {
            double res=this.missionS.Invoke(value);
            OnCalculate?.Invoke(this, res);

            return res;
        }
    }
}
