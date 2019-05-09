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
    public partial class Form5 : Form
    {
        GroupBox[] arrival;
        NumericUpDown[] values;
        TextBox[] namez;
        int idx = 0;
        int hi = 0;
        int tot;

        
        public Form5()
        {
            InitializeComponent();
            arrival = new GroupBox[Form1.no_of_processes];
            tot = 0;
            for (int i = 0; i < Form1.no_of_processes; i++)
            {
                tot = tot + Form1.no_of_segments[i];
            }
            values = new NumericUpDown[tot];
            namez = new TextBox[tot];
            Form1.name_of_segments = new String[tot];
            Form1.size_of_segments = new int[tot];
            names();
        }

        private void names()
        {
            GroupBox num_old = new GroupBox();
            num_old = this.groupBox_numberProcess;
            num_old.Enabled = true;
            int y = 30;
            arrival[0] = this.groupBox_numberProcess;
            //=========================================================================================================
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int yy = 60;
            for (int j = 1; j < Form1.no_of_segments[0]; j++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + yy);
                int xx =j + 1;
                new_lb.Text = "Segment " + xx;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.groupBox_numberProcess.Controls.Add(new_lb);
                yy = yy + 60;
            }
            //===============================
            NumericUpDown num_oldd = new NumericUpDown();
            num_oldd = this.num_p1_arrival;
            num_oldd.Enabled = true;
            int yyy = 60;
            values[idx] = this.num_p1_arrival;
            idx++;
            for (int j = 1; j < Form1.no_of_segments[0]; j++)
            {
                NumericUpDown numd = new NumericUpDown();
                numd.Size = num_oldd.Size;
                numd.Minimum = num_oldd.Minimum;
                numd.Maximum = num_oldd.Maximum;
                numd.TextAlign = num_oldd.TextAlign;
                numd.Location = new Point(num_oldd.Location.X, num_oldd.Location.Y + yyy);
                numd.Enabled = num_oldd.Enabled;
                numd.Name = "start_adress" + (j + 1).ToString();
                numd.BackColor = num_oldd.BackColor;
                numd.Font = num_oldd.Font;
                numd.TextAlign = num_oldd.TextAlign;
                numd.ReadOnly = num_oldd.ReadOnly;
                values[idx] = numd;
                idx++;
                this.groupBox_numberProcess.Controls.Add(numd);
                yyy = yyy + 60;
            }
            //===============================
            TextBox num_ol = new TextBox();
            num_ol = this.textBox1;
            num_ol.Enabled = true;
            int yyyy = 60;
            namez[hi] = this.textBox1;
            hi++;
            for (int j = 1; j < Form1.no_of_segments[0]; j++)
            {
                TextBox n = new TextBox();
                n.Size = num_ol.Size;
                n.TextAlign = num_ol.TextAlign;
                n.Location = new Point(num_ol.Location.X, num_ol.Location.Y + yyyy);
                n.Enabled = num_ol.Enabled;
                n.BackColor = num_ol.BackColor;
                n.Font = num_ol.Font;
                n.TextAlign = num_ol.TextAlign;
                n.ReadOnly = num_ol.ReadOnly;
                namez[hi] = n;
                hi++;
                this.groupBox_numberProcess.Controls.Add(n);
                yyyy = yyyy + 60;
            }
            //=========================================================================================================
            for (int i = 1; i < Form1.no_of_processes; i++)
            {
                GroupBox num = new GroupBox();
                int x = i + 1;
                num.Text = "Process " + x;
                num.AutoSize=true;
                num.Location = new Point(num_old.Location.X, arrival[i-1].Location.Y + arrival[i-1].Height+y);
                num.Enabled = num_old.Enabled;
                num.Name = "num" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                arrival[i] = num;
                this.panel1.Controls.Add(num);
                y = y + 30;
                //==========================
                old_lb = new Label();
                old_lb = this.lbl_p1;
                old_lb.Visible = true;
                yy = 60;
                for (int j = 0; j < Form1.no_of_segments[i]; j++)
                {
                    Label new_lb = new Label();
                    new_lb.Size = old_lb.Size;
                    new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + yy - 60);
                    int xx = j + 1;
                    new_lb.Text = "Segment " + xx;
                    new_lb.Font = old_lb.Font;
                    new_lb.BackColor = old_lb.BackColor;
                    new_lb.TextAlign = old_lb.TextAlign;
                    new_lb.Visible = true;
                    num.Controls.Add(new_lb);
                    yy = yy + 60;
                }
                //===============================
                num_oldd = new NumericUpDown();
                num_oldd = this.num_p1_arrival;
                num_oldd.Enabled = true;
                yyy = 60;
                for (int j = 0; j < Form1.no_of_segments[i]; j++)
                {
                    NumericUpDown numd = new NumericUpDown();
                    numd.Size = num_oldd.Size;
                    numd.Minimum = num_oldd.Minimum;
                    numd.Maximum = num_oldd.Maximum;
                    numd.TextAlign = num_oldd.TextAlign;
                    numd.Location = new Point(num_oldd.Location.X, num_oldd.Location.Y + yyy-60);
                    numd.Enabled = num_oldd.Enabled;
                    numd.BackColor = num_oldd.BackColor;
                    numd.Font = num_oldd.Font;
                    numd.TextAlign = num_oldd.TextAlign;
                    numd.ReadOnly = num_oldd.ReadOnly;
                    values[idx] = numd;
                    idx++;
                    num.Controls.Add(numd);
                    yyy = yyy + 60;
                }
                //===============================
                num_ol = new TextBox();
                num_ol = this.textBox1;
                num_ol.Enabled = true;
                yyyy = 60;
                for (int j = 0; j < Form1.no_of_segments[i]; j++)
                {
                    TextBox n = new TextBox();
                    n.Size = num_ol.Size;
                    n.TextAlign = num_ol.TextAlign;
                    n.Location = new Point(num_ol.Location.X, num_ol.Location.Y + yyyy-60);
                    n.Enabled = num_ol.Enabled;
                    n.BackColor = num_ol.BackColor;
                    n.Font = num_ol.Font;
                    n.TextAlign = num_ol.TextAlign;
                    n.ReadOnly = num_ol.ReadOnly;
                    namez[hi] = n;
                    hi++;
                    num.Controls.Add(n);
                    yyyy = yyyy + 60;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            Hide();
        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            bool ok = false;

            for (int i = 0; i < tot; i++)
            {
                Form1.size_of_segments[i] = (int)values[i].Value;
                String s=namez[i].Text.ToString();
                if (s == "" || s == " " || s == "  " || s == "   " || s == "    " || s == "     " || s == "      " || s == "       " || s == "         " || s == "          " || s == "        ") {
                    ok = true;
                }
                Form1.name_of_segments[i] = s;
            }
            if (ok)
            {
                MessageBox.Show("Please enter Valid names", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form6 form = new Form6();
                form.Show();
                Hide();
            }
        }
    }
}
