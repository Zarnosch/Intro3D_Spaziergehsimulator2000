using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Chunk : IChunk
    {
        int _hight;
        int _width;
        public Chunk(double[,] NoiseArray, int hight, int width)
        {
            this._hight = hight;
            this._width = width;
        }
    }
}
