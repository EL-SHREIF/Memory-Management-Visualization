using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentVisualization
{
    class hole
    {
        public int start;
        public int size;
        public bool alocated;
        public String name;
        public int process_index;
        public int hole_id;

        public hole(int s, int e)
        {
            start = s;
            size = e;
            alocated = false;
            name = "hole";
            process_index = -1;
            hole_id = 0;
        }
        public static void sort_by_start(List<hole> l)
        {
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[i].start > l[j].start)
                    {
                        hole temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
        public static void sort_by_size(List<hole> l)
        {
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[i].size > l[j].size)
                    {
                        hole temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
    }
}
