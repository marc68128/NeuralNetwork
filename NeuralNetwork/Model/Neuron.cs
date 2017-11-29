using System.Collections.Generic;
using NeuronalNetwork.Helpers;

namespace NeuralNetwork
{
    public class Neuron
    {
        public List<Dendrite> Dendrites { get; set; }
        public double Bias { get; set; }
        public double Delta { get; set; }
        public double Value { get; set; }

        public int DendriteCount => Dendrites.Count;

        public Neuron()
        {
            this.Bias = RandomHelper.NextDouble();
            this.Dendrites = new List<Dendrite>();
        }
    }
}