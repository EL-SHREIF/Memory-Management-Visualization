using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagmentVisualization
{
    class worstfit
    {
        public List<hole> holes;
        public List<process> processes;

        
        public List<process> holdProcesses;         //processes can't be allocated in memory
        public worstfit(List<hole> h, List<process> p)
        {
            holes = h;
            processes = p;
        }
        
        public void clearData()
        {
            holdProcesses.Clear();
        }

        public void computeWorstFit()
        {
            while (processes.Count > 0)
            {
                process temp = processes[0];
                processes.RemoveAt(0);
                List<hole> tempHoles = holes;
                int allocated = 0;
                for(int i = 0; i < temp.no_of_segments; i++)
                {
                    hole.sort2(tempHoles);
                    tempHoles.Reverse();
                    for(int j = 0; j < tempHoles.Count; j++)
                    {
                        if (tempHoles[j].alocated == false && tempHoles[j].size >= temp.segment_sizes[i])
                        {
                            hole tempHole = tempHoles[j];
                            tempHoles.RemoveAt(j);
                            int remainSize = tempHole.size - temp.segment_sizes[i];
                            tempHole.size = temp.segment_sizes[i];
                            allocated++;
                            tempHole.alocated = true;
                            tempHole.name = temp.name_of_segment[i];
                            tempHole.process_index = temp.process_id;
                            holes.Add(tempHole);
                            if (remainSize > 0)
                            {
                                tempHoles.Add(new hole(tempHole.start + tempHole.size, remainSize));
                            }
                            break;

                        }
                    }
                }
                if (allocated == temp.no_of_segments)
                {
                    holes = tempHoles;
                }
                else
                {
                    holdProcesses.Add(temp);
                }
            }
        }


    }
}
