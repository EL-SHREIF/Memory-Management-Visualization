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
        public hole(int s, int e)
        {
            start = s;
            size = e;
            alocated = false;
            name = "hole";
        }
        public static void sort(List<hole> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].start < l[j].start)
                    {
                        hole temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
            }
        }
        public static void sort2(List<hole> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[i].size < l[j].size)
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
