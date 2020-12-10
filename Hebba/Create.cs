using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    public class Create
    {
        public List<InputValue> CreateInput()
        {
            List<InputValue> inputs = new List<InputValue>()
            {
                new InputValue()
                {
                    Expected = new List<int>()
                    {
                        1,-1,-1,-1
                    },
                    Matrix = new List<int>()
                    {
                        1,1,-1,-1,
                        1,-1,1,-1,
                        1,-1,1,-1,
                        1,1,-1,-1
                    }
                },
                new InputValue()
                {
                    Expected = new List<int>()
                    {
                        -1,1,-1,-1
                    },
                    Matrix = new List<int>()
                    {
                        1,-1,-1,1,
                        1,1,1,1,
                        1,-1,-1,1,
                        1,-1,-1,1
                    }
                },
                new InputValue()
                {
                    Expected = new List<int>()
                    {
                        -1,-1,1,-1
                    },
                    Matrix = new List<int>()
                    {
                        1,1,1,1,
                        -1,1,1,-1,
                        -1,1,1,-1,
                        -1,1,1,-1
                    }
                },
                new InputValue()
                {
                    Expected = new List<int>()
                    {
                        -1,-1,-1,1
                    },
                    Matrix = new List<int>()
                    {
                        -1,1,1,-1,
                        1,-1,-1,1,
                        1,-1,-1,1,
                        -1,1,1,-1
                    }
                }
            };

            return inputs;
            
        }
    }
}
