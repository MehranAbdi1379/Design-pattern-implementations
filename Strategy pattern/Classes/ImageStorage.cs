using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Classes
{
    public class ImageStorage
    {
        private readonly IFilter filter;
        private readonly ICompressor compressor; 
        public ImageStorage(IFilter filter , ICompressor compressor)
        {
            this.filter = filter;   
            this.compressor = compressor;
        }

        public void Store()
        {
            filter.ApplyFilter();
            compressor.Compress();
        }
    }
}
