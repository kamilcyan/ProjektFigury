using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFigury.AreaProcessors
{
    public class RectangleProcessor : IProcessor
    {
        public float Calculate(string input)
        {
            var vals = input.Split(";").Select(x => int.Parse(x)).ToArray();

            int num1 = vals[0];
            int num2 = vals[1];

            return num1 * num2;
        }
    }
}
