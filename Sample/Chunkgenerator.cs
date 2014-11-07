using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Chunkgenerator
    {
        




        private double learp(double a0, double a1, double w)
        {
            return (1.0 - w) * a0 + w * a1;
        }

        private double[,] Noise(int hight, int width)
        {
            double[,] array = new double[hight, width];
            {
                for (int i = 0; i < hight; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        array[i, j] = new Random().NextDouble();
                    }
                }
            }
            for (int i = 1; i < hight-1; i++)
                {
                    for (int j = 1; j < width-1; j++)
                    {
                        array[i, j] += array[i+1,j] + array[i, j+1] + array[i-1, j] + array[i, j-1];
                        array[i, j] =array[i,j]/4;
                    }
                }
            return array;
        }
    }
}