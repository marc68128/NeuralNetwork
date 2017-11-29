using System;
using System.Collections.Generic;
using NeuralNetwork;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            NeuralNetwork.NeuralNetwork nn = new NeuralNetwork.NeuralNetwork(10, new[] { 2, 4, 4, 1 });

            for (int cnt = 0; cnt < 1000; cnt++)
            {
                var trainingInputs = new List<Data>();
                var trainingOutputs = new List<Data>();
                for (int i = 0; i < 10; i++)
                {
                    var a = rand.NextDouble();
                    var b = rand.NextDouble();
                    trainingInputs.Add(new Data { a, b });
                    trainingOutputs.Add(new Data { a * b });
                }
                nn.Train(trainingInputs, trainingOutputs);

                var testInputs = new List<Data>();
                var testOutputs = new List<Data>();
                for (int i = 0; i < 1000; i++)
                {
                    var a = rand.NextDouble();
                    var b = rand.NextDouble();
                    testInputs.Add(new Data { a, b });
                    testOutputs.Add(new Data { a * b });
                }

                var accuracy = nn.GetAccuracy(testInputs, testOutputs);
                Console.WriteLine(accuracy);
            }

            var res = nn.Run(new Data { 0.5, 0.5 });
            Console.Read();
        }
    }
}
