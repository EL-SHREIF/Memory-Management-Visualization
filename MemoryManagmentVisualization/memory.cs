using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentVisualization
{
    class memory
    {

        //zai ma t2ol kda kam 5anaa
        public int number_of_segments;

        public List<hole> segments;

        public memory(int n)
        {
            number_of_segments = n;
        }

        public memory(List<hole> all_holes)
        {
            segments=new List<hole>();
            hole.sort(all_holes);
            bool ok1=false,ok2=false;

            hole first = all_holes[0];
            hole last = all_holes[all_holes.Count - 1];

            if (first.start==0 && (last.start+last.size)==Form1.total_memory_size)
            {
                number_of_segments = all_holes.Count + all_holes.Count-1;
                ok1=true;ok2=true;
            }
            else if (first.start == 0 && (last.start + last.size) != Form1.total_memory_size)
            {
                number_of_segments = all_holes.Count + all_holes.Count ;
                ok1=true;ok2=false;
            }
            else if (first.start != 0 && (last.start + last.size) == Form1.total_memory_size)
            {
                number_of_segments = all_holes.Count + all_holes.Count+1;
                ok1=false;ok2=true;
            }
            else
            {
                number_of_segments = all_holes.Count + all_holes.Count;
                ok1=false;ok2=false;
            }

            if (!ok1)
            {
                hole h = new hole(0, all_holes[0].start);
                h.name = "out";
                segments.Add(h);
            }
            for (int i = 0; i < all_holes.Count; i++)
            {
                segments.Add(all_holes[i]);
                if (i != all_holes.Count - 1)
                {
                    int s = all_holes[i].start + all_holes[i].size;
                    int ss = all_holes[i + 1].start - all_holes[i].start + all_holes[i].size;
                    hole h = new hole(s, ss-s);
                    h.name = "out";
                    segments.Add(h);
                }
                else
                {
                    if (!ok2)
                    {
                        int s = all_holes[i].start + all_holes[i].size;
                        int ss = Form1.total_memory_size-s;
                        hole h = new hole(s, ss);
                        h.name = "out";
                        segments.Add(h);
                    }
                }
            }
        }   
    }
 }