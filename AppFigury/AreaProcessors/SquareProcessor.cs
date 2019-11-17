using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFigury.AreaProcessors
{
    public class SquareProcessor : IProcessor
    {
        public float Calculate(string input)
        {
            int num = int.Parse(input);

            return num * num;
        }
    }
}
