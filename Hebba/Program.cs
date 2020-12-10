using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hebba
{
    class Program
    {
        static void Main(string[] args)
        {
            Create create = new Create();
            Studying studying = new Studying();
            Data data = new Data();

            NeuralNetwork network = new NeuralNetwork(16,4);
            
            network.Inputs = create.CreateInput();
            studying.Start(network);


            Console.WriteLine("Started data:");
            Console.WriteLine();
            // Data
        
            ConsoleOutput.OutputMatrixAndLetter(network.Inputs[0].Matrix, 'D');
            ConsoleOutput.OutputMatrixAndLetter(network.Inputs[1].Matrix, 'M');
            ConsoleOutput.OutputMatrixAndLetter(network.Inputs[2].Matrix, 'T');
            ConsoleOutput.OutputMatrixAndLetter(network.Inputs[3].Matrix, 'O');

            Console.WriteLine("Training . . .");
            Console.Write("Test result: ");
            ConsoleOutput.Result(studying.Test(network));
            Console.WriteLine();

            Console.WriteLine("Tests:");
            foreach (var item in data.TestData.Values)
            {
                ConsoleOutput.OutputMatrixAndLetter(new List<int>(item), network.GetResult(item));
                
            }

            Console.ReadLine();
        }
    }
}
