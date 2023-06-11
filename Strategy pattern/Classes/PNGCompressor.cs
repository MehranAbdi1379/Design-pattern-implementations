using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Classes
{
    public class PNGCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("PNG Compressor is used.");
        }
    }
}
