using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFigury.AreaProcessors
{
    public interface IProcessor
    {
        float Calculate(string input);
    }
}
