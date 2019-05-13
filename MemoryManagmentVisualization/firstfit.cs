using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocation
{
    class firstfit
    {
        //Inputs:
        public List<hole> holes;
        public List<process> processes = new List<process>();
        public List<process> segments_not_allocated = new List<process>();


        //Constructor: "here we take the input"
        public firstfit(List<hole> initial_holes, List<process> allocation_process)
        {
            holes = initial_holes;
            processes = allocation_process;
        }


        public bool Process_IS_Fit(process p)
        {
            bool fitted = false;
            int sum_segments_sizes = 0;

            if (holes.Count == 1)
            {
                for (int j = 0; j < p.no_of_segments; j++)
                    sum_segments_sizes = sum_segments_sizes + p.segment_sizes[j];

                //1.1 The only case to allocate the process in the hole
                if (holes[0].size >= sum_segments_sizes)
                    return true;
                else
                    return false;
            }

            int[] holes_size = new int[holes.Count];
            for (int j = 0; j < holes.Count; j++)
                holes_size[j] = holes[j].size;


            for (int j = 0; j < p.no_of_segments; j++)
            {
                int segment_size = p.segment_sizes[j];   //code = 170

                for (int i = 0; i < holes.Count; i++)
                {
                    if (holes_size[i] >= segment_size)
                    {
                        holes_size[i] = holes_size[i] - segment_size;
                        fitted = true;
                        break;
                    }

                    else
                        fitted = false;
                }

                if (!fitted)
                    return fitted;
            }
            return fitted;
        }


        public void First_Fit_Algorithm()
        {
            int process_segments_number;
            int segment_Size;
            string segment_name;
            int remained_hole_size;
            //  int allocated_not_done = 0;
            //  int place = 0;

            while (processes.Count > 0)
            {
                //store each process info then remove it:
                process allocation_process = processes[0];
                process p = allocation_process;
                processes.RemoveAt(0);

                if (!Process_IS_Fit(allocation_process))
                {
                    segments_not_allocated.Add(allocation_process);
                    continue;
                }

                process_segments_number = allocation_process.no_of_segments;
                bool[] segment_allocation_done = new bool[process_segments_number];

                for (int i = 0; i < process_segments_number; i++)
                {
                    segment_Size = allocation_process.segment_sizes[i];
                    segment_name = allocation_process.name_of_segment[i];
                    segment_allocation_done[i] = false;

                    for (int j = 0; j < holes.Count; j++)
                    {
                        //There is a hole and its size equal or more than the required size for the segment:
                        if ((holes[j].alocated == false) && (holes[j].size >= segment_Size))
                        {
                            holes[j].alocated = true;
                            // segment_allocation_done[i] = true;
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
                    //if (!segment_allocation_done[i])
                    //  allocated_not_done++;
                }

                /*
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
                                p.segment_sizes[place] = allocation_process.segment_sizes[k];
                                place++;
                            }
                        }
                        segments_not_allocated.Add(p);
                    }
                }
                */
            }

        }
    }
}
