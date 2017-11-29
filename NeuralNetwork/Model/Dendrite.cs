using NeuronalNetwork.Helpers;

namespace NeuralNetwork
{
    public class Dendrite
    {
        public double Weight { get; set; }

        public Dendrite()
        {
            this.Weight = RandomHelper.NextDouble();
        }
    }
}