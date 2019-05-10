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
    public partial class Form4 : Form
    {
        NumericUpDown[] arrival;

        //List<hole> holes;
        public Form4()
        {
            InitializeComponent();
            arrival = new NumericUpDown[Form1.no_of_processes + 1];
            Form1.no_of_segments = new int[Form1.no_of_processes];
            names();
            starts();
        }
        private void names()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form1.no_of_processes; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process " + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.groupBox_processDetail.Controls.Add(new_lb);
                y = y + 60;
            }
        }

        private void starts()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.num_p1_arrival;
            num_old.Enabled = true;
            int y = 60;
            arrival[0] = this.num_p1_arrival;
            for (int i = 1; i < Form1.no_of_processes; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "num" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                num.TextAlign = num_old.TextAlign;
                num.ReadOnly = num_old.ReadOnly;
                arrival[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num_p1_arrival_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Form1.no_of_processes; i++)
            {
                Form1.no_of_segments[i] = (int)arrival[i].Value;
            }
            Form5 form = new Form5();
            form.Show();
            Hide(); 
        }
    }
}
