/// yael mohaban
/// 205379126
/// group 05

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise_1
{
    class ComposedMission : IMission
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public event EventHandler<double> OnCalculate;


        public delegate double composedDel(double val);
        private IList<composedDel> listMission;
        /// <summary>
        /// the constractur of the class
        /// </summary>
        /// <param name="name"> the name of the mission</param>
        public ComposedMission(string name)
        {
            this.Name = name;
            this.Type = "Composed";
            this.listMission = new List<composedDel>();
        }
        /// <summary>
        /// the function create list of all the fucntion it get and return the list
        /// </summary>
        /// <param name="func"> the function to add to the list</param>
        /// <returns>list of function</returns>
        public ComposedMission Add(Func<double, double> func)
        {
            composedDel com = new composedDel(func);
            this.listMission.Add(com);
            return this;
        }
        /// <summary>
        /// the fucntion calculate all the function it have in the list
        /// </summary>
        /// <param name="value"> the value to send to the function</param>
        /// <returns> return the value after claculate all the function in the list</returns>
        public double Calculate(double value)
        {
            foreach (var i in listMission)
            {
                value = i.Invoke(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
