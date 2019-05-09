using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_OS
{
    class BestFit
    {
             
        public BestFit(List<process> p, List<hole> h)
        {
            List<hole> output_memory = new List<hole>();
            output_memory = func(p, h);
           // print(output_memory, memory_size);
        }

        public static List<hole> func(List<process> p, List<hole> h)
        {
            hole.sort_by_start(h);
            List<hole> final_memory = new List<hole>();
            List<hole> empty_holes = new List<hole>();
            empty_holes = h;
            int no_of_holes = h.Count;
            hole m;
            int k = 0;
            int size=0;
            int j;
            int x;
            int[] counter = new int[no_of_holes];
            for (int i = 0; i < no_of_holes; i++)
            {
                counter[i] = 0;
            }
            
            int total_sgements = 0;
            for (int i = 0; i < p.Count; i++)
            {
               total_sgements = p[i].no_of_segments +total_sgements ;
            }

            Compaction_Before(empty_holes, ref no_of_holes);
                for (int i = 0; i < p.Count; i++)
                {
                    for ( x = 0; x < p[i].no_of_segments; x++)
                    {
                        List<hole> best_holes = new List<hole>();
                        for (j = 0; j < no_of_holes; j++)
                        {
                            if (!empty_holes[j].alocated)
                            {
                                if (p[i].segment_sizes[x] <= empty_holes[j].size)
                                {

                                    size = h[j].size - p[i].segment_sizes[x];
                                    k++;
                                    m = new hole(h[j].start, size);
                                    m.hole_id = h[j].hole_id;
                                    best_holes.Add(m);

                                    if (k > 1)
                                    {
                                        hole.sort_by_size(best_holes);
                                    }
                                }                              
                            }
                           
                        }

                        if (k != 0)
                        {
                           
                            if (best_holes[0].size == 0)
                            {
                               empty_holes[best_holes[0].hole_id].alocated = true;
                               empty_holes[best_holes[0].hole_id].name = p[i].name_of_segment[x];
                               final_memory.Add(empty_holes[best_holes[0].hole_id]);

                            }

                            else
                            {                             
                                int a = best_holes[0].start;
                                int b = p[i].segment_sizes[x];
                                hole t = new hole(a, b);                               
                                t.alocated = true;
                                t.name = p[i].name_of_segment[x];
                                final_memory.Add(t);
                                hole.sort_by_start(final_memory);
                                // second hole after splitting
                                int z = t.start + t.size;
                                int y = best_holes[0].size;
                                hole s = new hole(z, y);
                                empty_holes[best_holes[0].hole_id].start = s.start;
                                empty_holes[best_holes[0].hole_id].size = s.size;
                                Compaction_After(empty_holes, best_holes, ref no_of_holes);                                                                                      
                                hole.sort_by_start(empty_holes);
                            }
                            k = 0;                           
                        }
                    }                
                    hole.sort_by_start(final_memory);
                }
                for (int i = 0; i < no_of_holes; i++)
                {
                    if (!empty_holes[i].alocated)
                    {                      
                        final_memory.Add(empty_holes[i]);
                        hole.sort_by_start(final_memory);

                    }
                }

                    return final_memory;
        }

        public static void Compaction_Before(List<hole> empty_holes, ref int no_of_holes)
        {
            for (int i = 0; i < no_of_holes-1; i++)
            {
                for (int j = i + 1; j < no_of_holes; j++)
                {
                    if ((empty_holes[i].start + empty_holes[i].size) == empty_holes[j].start)
                    {
                        empty_holes[i].size = empty_holes[i].size + empty_holes[j].size;
                        no_of_holes--;
                        empty_holes.Remove(empty_holes[j]);

                        if (i >= no_of_holes - 1)
                        {
                            break;
                        }
                    }
                }                   
            }                  
            for (int j = 0; j < no_of_holes; j++)
            {
                empty_holes[j].hole_id = j;
            }
        }



        public static void Compaction_After(List<hole> empty_holes ,List<hole> best_holes ,ref int no_of_holes)
        {          
            int u = best_holes[0].hole_id;

            if (u < no_of_holes - 1)
            {
                while ((empty_holes[u].start + empty_holes[u].size) == empty_holes[u + 1].start)
                {
                    empty_holes[u].size = empty_holes[u].size + empty_holes[u + 1].size;
                    no_of_holes--;
                    empty_holes.Remove(empty_holes[u + 1]);

                    if (u >= no_of_holes - 1)
                    {
                        break;
                    }

                }
            }

            
            for (int i = 0; i < no_of_holes; i++)
            {
                empty_holes[i].hole_id = i;
            }
        }

        /*public static void print(List<hole> l, int memory_size)
        {
            List<hole> output =new List<hole>();
            hole.sort_by_start(l);
                   

            // for first location in block
            for (int i = 0; i <1; i++)
            {
               int size = l[i].start - 0;

                if (size !=0)
                {
                    hole h = new hole(0 , size);
                    h.alocated = true;
                    h.name = "old process";
                    output.Add(h);
                    output.Add(l[0]);
                }

                else if (size == 0)
                {

                    output.Add(l[i]);
                }

            }

            // for locations between memory
            for (int i = 1; i <l.Count; i++)
            {
               int size = l[i].start - (l[i-1].start + (l[i-1].size));

                if (size !=0)
                {
                    hole h = new hole(l[i-1].start + l[i-1].size , size);
                    h.alocated = true;
                    h.name = "old process";
                    output.Add(h);
                    output.Add(l[i]);
                }

                else if (size == 0)
                {

                    output.Add(l[i]);
                }

            }

            // for last location in memory
            for (int i = l.Count-1; i < l.Count; i++)
            {
                int size = memory_size - (l[i].start + l[i].size);

                if (size != 0)
                {
                    hole h = new hole(l[i].start + l[i].size, size);
                    h.alocated = true;
                    h.name = "old process";
                    output.Add(h);
                }

                else if (size == 0)
                {

                    output.Add(l[i]);
                }

            }


            for (int i = 0; i < output.Count; i++)
            {
               
                int end =  output[i].start + output[i].size;
                Console.WriteLine("\n");
                Console.WriteLine(output[i].start);
                Console.WriteLine("->");
                Console.WriteLine(output[i].name);
                Console.WriteLine("->");
                Console.WriteLine(end);
            }                  
        }*/
    }
}
