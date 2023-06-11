using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Classes
{
    public class JPEGCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("JPEG compressor is used.");
        }
    }
}
