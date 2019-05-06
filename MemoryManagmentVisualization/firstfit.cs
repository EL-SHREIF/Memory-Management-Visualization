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
        public static List<hole> holes;
        public static List<process> processes;

        //Processes can't be allocated in the memory:
        //  public List<hole> segments_not_allocated;

        //Constructor: "here we take the input"
        public firstfit(List<hole> initial_holes, List<process> allocation_process)
        {
            holes = initial_holes;
            processes = allocation_process;
        }

        public static void First_Fit_Algorithm()
        {
            int process_segments_number;
            int segment_Size;
            string segment_name;
            int remained_hole_size;


            while (processes.Count > 0)
            {
                //store each process info then remove it:
                process allocation_process = processes[0];
                processes.RemoveAt(0);

                process_segments_number = allocation_process.no_of_segments;
                for (int i = 0; i < process_segments_number; i++)
                {
                    segment_Size = allocation_process.segment_sizes[i];
                    segment_name = allocation_process.name_of_segment[i];
                    bool segment_allocation_done = false;

                    for (int j = 0; j < holes.Count; j++)
                    {
                        //There is a hole and its size equal or more than the required size for the segment:
                        if ((holes[j].alocated == false) && (holes[j].size >= segment_Size))
                        {
                            holes[j].alocated = true;
                            segment_allocation_done = true;
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
                    if (!segment_allocation_done)
                    {
                        //segments_not_allocated.Add(new hole ) 
                    }

                }

            }

        }

    }
}
