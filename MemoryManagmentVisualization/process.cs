using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentVisualization
{
    class process
    {
        public int process_id;
        public int no_of_segments;
        public String[] name_of_segment;
        public int[] segmenst_sizes;
      

        public process(int i, int number_segments)
        {
            process_id = i;
            no_of_segments = number_segments;
            name_of_segment = new String [no_of_segments];
            segmenst_sizes = new int[no_of_segments];
        }
    }
}
        