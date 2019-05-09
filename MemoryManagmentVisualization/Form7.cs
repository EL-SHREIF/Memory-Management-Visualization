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
    public partial class Form7 : Form
    {

        List<hole> holes = new List<hole>();
        List<hole> segments = new List<hole>();
        memory mem;
        List<process> processes;
        int num_of_process;
        Color[] colors;
      
        public Form7()
        {
            InitializeComponent();

            
            num_of_process=Form1.no_of_processes;

            for (int i = 0; i < Form1.no_of_holes; i++) {
                hole h= new hole(Form1.holes_start_adress[i],Form1.holes_sizes[i]);
                holes.Add(h);
            }

            int idx = 0;

            for (int i = 0; i < Form1.no_of_processes; i++)
            {
                process p = new process(i + 1, Form1.no_of_segments[i]);
                for (int j = 0; j < Form1.no_of_segments[i]; j++) {
                    p.segmenst_sizes[j] = Form1.size_of_segments[idx];
                    p.name_of_segment[j] = Form1.name_of_segments[idx];
                    idx++;
                }
                //processes.Add(p);
            }

            colors = new Color[15];
            colors[0] = Color.Maroon;
            colors[1] = Color.Yellow;
            colors[2] = Color.Violet;
            colors[3] = Color.Blue;
            colors[4] = Color.Lime;
            colors[5] = Color.Chocolate;
            colors[6] = Color.Aqua;
            colors[7] = Color.DarkGreen;
            colors[8] = Color.Maroon;
            colors[9] = Color.Pink;
            colors[10] = Color.Silver;
            colors[11] = Color.BlanchedAlmond;
            colors[12] = Color.Cyan;
            colors[13] = Color.Fuchsia;
            colors[14] = Color.Gold;

            Draw();
        }

        void Draw() {
            mem = new memory(holes);

            Label l = new Label();
            int x = this.label3.Location.X;
            int y = this.label3.Location.Y;
            int len = 35;
            //===================
            Label flag = new Label();
            flag = this.label4;
            flag.Location = new Point(this.label4.Location.X , this.label4.Location.Y);
            flag.Visible = true;
            this.tabPage_GanttChart.Controls.Add(flag);
            Label n = new Label();
            n = this.label5;
            n.Location = new Point(this.label5.Location.X , this.label5.Location.Y);
            n.Visible = true;
            this.tabPage_GanttChart.Controls.Add(n);
            //=========================
            l = this.label3;
            l.Font = this.label3.Font;
            l.ForeColor = this.label3.ForeColor;
            l.Size = this.label3.Size;
            int place=0;
            for (int i = 0; i < mem.number_of_segments; i++)
            {
                Label l2 = new Label();
                l2.TextAlign = l.TextAlign;
                l2.Location = new Point(x, y);
                len = 35;
                if(mem.segments[i].name=="out"){
                    l2.BackColor = colors[0];
                    l2.Text= "";
                    place =  mem.segments[i].size + place;
                }
                else if(mem.segments[i].name=="hole"){
                    l2.BackColor = Color.Gray;
                    l2.Text="hole";
                    place = place + mem.segments[i].size;
                }
                else
                {
                    l2.Text = "P" + (mem.segments[i].process_index + 1).ToString() + ": " + mem.segments[i].name;
                    l2.BackColor = colors[(mem.segments[i].process_index + 1)%15];
                    place = place + mem.segments[i].size;
                }
                l2.Font = this.label3.Font;
                l2.ForeColor = this.label3.ForeColor;
                l2.Size = this.label3.Size;
                y = y + len;
                this.tabPage_GanttChart.Controls.Add(l2);
                //===============================================
                Label flag2 = new Label();
                Label n2 = new Label();
                flag2.BackColor = flag.BackColor;
                flag2.Size = this.label4.Size;
                flag2.Location = new Point(flag.Location.X, flag.Location.Y + len);
                flag2.Visible = true;
                n2.Size = this.label5.Size;
                n2.Location = new Point(n.Location.X, n.Location.Y + len);
                n2.Visible = true;
                n2.BackColor = Color.Black;
                flag2.Text = place.ToString();
                this.tabPage_GanttChart.Controls.Add(flag2);
                this.tabPage_GanttChart.Controls.Add(n2);
                l = l2;
                n = n2;
                flag = flag2;
            }
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            int promptValue = Form7.ShowDialog("Number Of Segments", "enter no of segments");
            process p=Form7.ShowDialog2("enter process data", "new process",promptValue,num_of_process);
            num_of_process++;
        }
        private static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300; 
            prompt.Height = 300;
            prompt.Text = caption;
            prompt.BackColor = Color.MistyRose;
            Label textLabel = new Label() { Left = 50, Top = 64, Width = 200, Height = 41, Text = text, BackColor = Color.Gray,Font=new Font("Segoe UI", 14F) };
            NumericUpDown inputBox = new NumericUpDown() { Left = 100, Top = 123, Width = 89,Font=new Font("Segoe UI", 14F), Height = 50, Minimum = 1, BackColor = Color.Bisque, Value = 1 , Visible=true,ForeColor=Color.Black};
            Button confirmation = new Button() { Text = "Ok", Left = 100, Top = 200, ForeColor = Color.DodgerBlue, Width = 88, Height = 46, BackColor = Color.Aquamarine };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return (int)inputBox.Value;
        }

        private static process ShowDialog2(string text, string caption,int x,int idx)
        {
            process p = new process(idx, x);
            Form prompt = new Form();
            prompt.Width = 600;
            prompt.Height = 600;
            prompt.AutoScroll = true;
            prompt.Text = caption;
            NumericUpDown[] values = new NumericUpDown[x];
            TextBox[] names = new TextBox[x];
            prompt.BackColor = Color.MistyRose;
            Label textLabel = new Label() { Left = 50, Top = 64, Width = 200, Height = 41, Text = text, BackColor = Color.Gray, Font = new Font("Segoe UI", 14F) };
            //===============================
            NumericUpDown num_oldd = new NumericUpDown();
            num_oldd = new NumericUpDown() { Left = 100, Top = 123,Maximum=10000000000, Width = 89, Font = new Font("Segoe UI", 14F), Height = 50, Minimum = 1, BackColor = Color.Bisque, Value = 1, Visible = true, ForeColor = Color.Black };
            num_oldd.Enabled = true;
            int y = 60;
            int m = num_oldd.Location.Y;
            for (int j = 0; j < x; j++)
            {
                NumericUpDown numd = new NumericUpDown();
                numd.Size = num_oldd.Size;
                numd.Minimum = num_oldd.Minimum;
                numd.Maximum = num_oldd.Maximum;
                numd.TextAlign = num_oldd.TextAlign;
                numd.Location = new Point(num_oldd.Location.X, num_oldd.Location.Y + y - 60);
                numd.Enabled = num_oldd.Enabled;
                numd.BackColor = num_oldd.BackColor;
                numd.Font = num_oldd.Font;
                numd.TextAlign = num_oldd.TextAlign;
                numd.ReadOnly = num_oldd.ReadOnly;
                values[j] = numd;
                prompt.Controls.Add(numd);
                y = y + 60;
            }
            //===============================
            TextBox num_ol = new TextBox();
            num_ol.Enabled = true;
            int yy = 60;
            for (int j = 0; j < x; j++)
            {
                TextBox n = new TextBox();
                n.Size = num_ol.Size;
                n.TextAlign = num_ol.TextAlign;
                n.Location = new Point(num_oldd.Location.X+100, m + yy - 60);
                n.Enabled = num_ol.Enabled;
                n.BackColor = num_ol.BackColor;
                n.Font = num_ol.Font;
                n.TextAlign = num_ol.TextAlign;
                n.ReadOnly = num_ol.ReadOnly;
                names[j] = n;
                prompt.Controls.Add(n);
                yy = yy + 60;
            }
            Button confirmation = new Button() { Text = "Ok", Left = 100, Top = yy+50, ForeColor = Color.DodgerBlue, Width = 88, Height = 46, BackColor = Color.Aquamarine };
            confirmation.Click += (sender, e) => {
                bool ok = false;
                
              
                for (int i = 0; i < x; i++)
                {
                    p.segmenst_sizes[i] = (int)values[i].Value;
                    String s = names[i].Text.ToString();
                    if (s == "" || s == " " || s == "  " || s == "   " || s == "    " || s == "     " || s == "      " || s == "       " || s == "         " || s == "          " || s == "        ")
                    {
                        ok = true;
                    }
                    p.name_of_segment[i] = s;
                }
                if (ok)
                {
                    MessageBox.Show("Please enter Valid names", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    prompt.Close(); 
                }
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
            return p;
        }
    }
}
