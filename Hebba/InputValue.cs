using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    public class InputValue
    {
        public InputValue()
        {
            Matrix = new List<int>();
            Expected = new List<int>();
        }

        public List<int> Matrix { get; set; }
        public List<int> Expected { get; set; }
    }
}
