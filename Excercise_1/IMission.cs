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
    /// the interface of mission, the event calculate all the function it has
    /// name is the name of the mission
    /// type is witch type the mission - single or composed
    /// calculate - return the value after the calculate of the function
    /// </summary>
    interface IMission
    {
        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get; }
        String Type { get; }

        double Calculate(double value);
    }
}
