using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManagmentVisualization
{
    public partial class Form6 : Form
    {
        List<hole> holes;
        List<process> processes;

        public Form6()
        {
            InitializeComponent();
            input();
        }

        private void input() { 
            holes = new List<hole>();
            processes = new List<process>();
            //==========================================
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 60;
            //=========================================
            
            for (int i = 0; i<Form1.no_of_holes; i++)
            {
                hole h = new hole(Form1.holes_start_adress[i], Form1.holes_sizes[i]);
                holes.Add(h);
            }
            int idx = 0;
            for (int i = 0; i < Form1.no_of_processes; i++)
            {
                process p = new process( i+1, Form1.no_of_segments[i]);
                //=======================emsa7 mn awl hna===============================
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "p"+p.process_id.ToString();
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.panel1.Controls.Add(new_lb);
                y = y + 60;
                //==============================l7ad hna==================================
                for (int j = 0; j < Form1.no_of_segments[i] ; j++)
                {
                    p.segmenst_sizes[j] = Form1.size_of_segments[idx];
                    p.name_of_segment[j] = Form1.name_of_segments[idx];
                    //=============================emsa7 mn awl hna================================
                    new_lb = new Label();
                    new_lb.Size = old_lb.Size;
                    new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                    new_lb.Text = p.name_of_segment[j].ToString();
                    new_lb.Font = old_lb.Font;
                    new_lb.BackColor = old_lb.BackColor;
                    new_lb.TextAlign = old_lb.TextAlign;
                    new_lb.Visible = true;
                    this.panel1.Controls.Add(new_lb);
                    y = y + 60;
                    new_lb = new Label();
                    new_lb.Size = old_lb.Size;
                    new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                    new_lb.Text = "sz=" + p.segmenst_sizes[j].ToString();
                    new_lb.Font = old_lb.Font;
                    new_lb.BackColor = old_lb.BackColor;
                    new_lb.TextAlign = old_lb.TextAlign;
                    new_lb.Visible = true;
                    this.panel1.Controls.Add(new_lb);
                    y = y + 60;
                    //=====================================l7d hna========================
                    idx++;
                }
                processes.Add(p);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            Hide();
        }
    }
}
