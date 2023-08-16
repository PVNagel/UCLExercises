using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd
{
    public class Controller
    {
        //public void Add(BlomsterSort blomsterSort)
        //{
        //    blomsterSorter.Add(blomsterSort)
        //}
        private List<BlomsterSort> blomsterSorter = new List<BlomsterSort>();
        public void Add(BlomsterSort blomsterSort)
        {
            blomsterSorter.Add(blomsterSort);
        }
    }
}
