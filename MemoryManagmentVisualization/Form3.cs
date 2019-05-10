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
    public partial class Form3 : Form
    {
        NumericUpDown[] arrival;
        NumericUpDown[] brust;

        

        public Form3()
        {
            InitializeComponent();

            arrival = new NumericUpDown[Form1.no_of_holes+1];
            brust = new NumericUpDown[Form1.no_of_holes+1];

            Form1.holes_start_adress = new int[Form1.no_of_holes];
            Form1.holes_sizes= new int[Form1.no_of_holes];

            names();
            starts();
            sizes();
        }

        private void names()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form1.no_of_holes; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Hole " + x;
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
            for (int i = 1; i < Form1.no_of_holes; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "start_adress" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                num.TextAlign = num_old.TextAlign;
                num.ReadOnly= num_old.ReadOnly;
                arrival[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }
        private void sizes()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.num_p1_burst;
            num_old.Enabled = true;
            int y = 60;
            brust[0] = this.num_p1_burst;
            for (int i = 1; i < Form1.no_of_holes; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "size" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.TextAlign = num_old.TextAlign;
                num.ReadOnly = num_old.ReadOnly;
                num.Font = num_old.Font;
                brust[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + 60;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok1 = true;
            bool ok2 = true;
            for (int i = 0; i < Form1.no_of_holes; i++)
            {
                Form1.holes_start_adress[i] = (int)arrival[i].Value;
                Form1.holes_sizes[i] = (int)brust[i].Value;
            }
            int max_adress=Form1.total_memory_size-1;
            for (int i = 0; i < Form1.no_of_holes; i++)
            {
                int x = Form1.holes_start_adress[i];
                int y = Form1.holes_sizes[i];
                if (x > max_adress || (x + y) > max_adress+1)
                    ok2 = false;
            }

            for (int i = 0; i < Form1.no_of_holes; i++)
            {
                int x = Form1.holes_start_adress[i];
                int y = Form1.holes_sizes[i];
                for (int j = 0; j < Form1.no_of_holes; j++)
                {
                    int xx = Form1.holes_start_adress[j];
                    if (j != i) {
                        if (x == xx)
                        {
                            ok1 = false;
                            break;                        
                        }
                        else if (x < xx && (x + y) > xx)
                        {
                            ok1 = false;
                            break;
                        }
                        else if ((x + y) == xx)
                        {
                            ok1 = false;
                            break;
                        }
                    }
                }
            }

            if (ok1&&ok2)
            {
                if (Form1.no_of_processes == 0)
                {
                    Form6 form = new Form6();
                    form.Show();
                    Hide();
                }
                else
                {
                    Form4 form = new Form4();
                    form.Show();
                    Hide();
                } 
            }
            else if (ok2==false)
            {
                MessageBox.Show("Please enter correct adresses and sizes as these holes extend the memory limit", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You shouldn't enter overlapped holes", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
