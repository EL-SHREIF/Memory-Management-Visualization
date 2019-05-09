using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentVisualization
{
     class firstfit
    {

        //Inputs:
        public List<hole> holes;
        public List<process> processes= new List<process> ();
        public List<process> segments_not_allocated = new List<process> ();

        
        //Constructor: "here we take the input"
        public firstfit(List<hole> initial_holes, List<process> allocation_process)
        {
            holes = initial_holes;
            processes = allocation_process;
        }

        public void First_Fit_Algorithm()
        {
            int process_segments_number;
            int segment_Size;
            string segment_name;
            int remained_hole_size;
            int allocated_not_done = 0;
            int place = 0;

            while (processes.Count > 0)
            {
                //store each process info then remove it:
                process allocation_process = processes[0];
                process p = allocation_process;
                processes.RemoveAt(0);

                process_segments_number = allocation_process.no_of_segments;
                bool[] segment_allocation_done = new bool[process_segments_number]; 

                for (int i = 0; i < process_segments_number; i++)
                {
                    segment_Size = allocation_process.segmenst_sizes[i];
                    segment_name = allocation_process.name_of_segment[i];
                    segment_allocation_done[i] = false;

                    for (int j = 0; j < holes.Count; j++)
                    {
                        //There is a hole and its size equal or more than the required size for the segment:
                        if ((holes[j].alocated == false) && (holes[j].size >= segment_Size))
                        {
                            holes[j].alocated = true;
                            segment_allocation_done[i] = true;
                            remained_hole_size = holes[j].size - segment_Size;
                            holes[j].size = segment_Size;
                            holes[j].name = segment_name;
                            holes[j].process_index = allocation_process.process_id;

                            if (remained_hole_size != 0)
                            {
                                holes.Insert(j + 1, new hole(holes[j].start + holes[j].size, remained_hole_size));
                            }

                            break;
                        }
                    }
                    if (!segment_allocation_done[i])
                        allocated_not_done++;
                }

                if (allocated_not_done != 0)
                {
                    //No one of process segment is allocated:
                    if (allocated_not_done == process_segments_number)
                    {
                        segments_not_allocated.Add(allocation_process);
                    }
                    else 
                    {
                      p.no_of_segments = allocated_not_done;
                      for (int k = 0; k < process_segments_number; k++)
                      {
                          if (segment_allocation_done[k] == false)
                          {
                            p.name_of_segment[place] = allocation_process.name_of_segment[k];
                            p.segmenst_sizes[place] = allocation_process.segmenst_sizes[k];
                            place++;
                          } 
                      }
                      segments_not_allocated.Add(p);
                    }
                }
            }

        }

    }
}


