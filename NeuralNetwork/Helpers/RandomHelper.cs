using System;
using System.Security.Cryptography;

namespace NeuronalNetwork.Helpers
{
    internal static class RandomHelper
    {
        private static Random _random; 
        static RandomHelper()
        {
            using (RNGCryptoServiceProvider p = new RNGCryptoServiceProvider())
            {
                _random = new Random(p.GetHashCode());
            }
        }

        public static double NextDouble()
        {
            return _random.NextDouble(); 
        }
    }
}