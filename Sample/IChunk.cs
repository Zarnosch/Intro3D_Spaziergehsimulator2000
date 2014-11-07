using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{

    interface IChunk
    {
        int hight
        {
            get;
            set;
        }
        int width
        {
            get;
            set;
        }
        double[,] NoiseArray
        {
            get;
            set;
        }
    }


}
