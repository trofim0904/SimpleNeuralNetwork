using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    public class Studying
    {
        public void Start(NeuralNetwork network)
        {
            int rows = network.Weights.GetLength(0);
            int columns = network.Weights.GetLength(1);

            for (int j = 0; j < rows; j++)
            {
                for(int i = 0; i < columns; i++)
                {
                    network.Weights[j, i] = 0;
                }
            }
            network.Weights[0, 0] = 1;

            foreach (InputValue input in network.Inputs)
            {
                for (int j = 0; j < rows; j++)
                {
                    for (int i = 0; i < columns; i++)
                    {
                        network.Weights[j, i] += input.Expected[i] * input.Matrix[j]; 
                    }
                }
            }
        }

        public bool Test(NeuralNetwork network)
        {
            int rows = network.Weights.GetUpperBound(0) + 1;
            int columns = network.Weights.Length / rows;

            for(int i = 0; i < columns; i++)
            {
                if (!Check(network, i)) return false;
            }
           
            return true;
        }
        private bool Check(NeuralNetwork network, int i) 
        {
            int rows = network.Weights.GetUpperBound(0) + 1;
            int columns = network.Weights.Length / rows;
            
            int checkresult = 1;
            bool result = true;

            for (int k = 0; k < columns; k++)
            {
                int value = 0;

                for (int j = 0; j < rows; j++)
                {
                    value += network.Weights[j, k] * network.Inputs[i].Matrix[j];
                }

                if (value > 0)
                {
                    checkresult = 1;
                }
                else
                {
                    checkresult = -1;
                }

                if (checkresult != network.Inputs[i].Expected[k])
                {
                    result = result && false;
                }
                else
                {
                    result = result && true;
                }
            }
            return result;
        }
    }
}
