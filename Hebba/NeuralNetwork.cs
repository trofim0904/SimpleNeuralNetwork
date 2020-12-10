using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebba
{
    
    public class NeuralNetwork
    {
        public int[,] Weights { get; set; }
        public List<InputValue> Inputs { get; set; }
        
        public List<int> Output { get; set; }

        public NeuralNetwork(int inputs, int outputs)
        {
            Weights = new int[inputs, outputs];
            Inputs = new List<InputValue>();
            Output = new List<int>();
        }


        public char GetResult(int[] input)
        {
            int rows = Weights.GetUpperBound(0) + 1;
            int columns = Weights.Length / rows;

            for (int i = 0; i < columns; i++)
            {
                Output.Add(Calculate(i, input));
            }
            char result = ListToChar();
            Output = new List<int>();
            return result;
        }

        private int Calculate(int i, int[] input)
        {
            int rows = Weights.GetUpperBound(0) + 1;
            int value = 0;
            

            for (int j = 0; j < rows; j++)
            {
                value += Weights[j, i] * input[j];
            }

            if (value > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private char ListToChar()
        {
            
            if(Output[0] == 1 && Output[1] == -1 && Output[2] == -1 && Output[3] == -1)
            {
                return 'D';
            }
            if (Output[0] == -1 && Output[1] == 1 && Output[2] == -1 && Output[3] == -1)
            {
                return 'M';
            }
            if (Output[0] == -1 && Output[1] == -1 && Output[2] == 1 && Output[3] == -1)
            {
                return 'T';
            }
            if (Output[0] == -1 && Output[1] == -1 && Output[2] == -1 && Output[3] == 1)
            {
                return 'O';
            }

            return '?';
        }

    }
}
