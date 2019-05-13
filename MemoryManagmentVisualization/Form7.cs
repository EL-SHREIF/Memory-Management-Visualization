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
        firstfit schedular1;
        worstfit schedular2;
        bestfit1 schedular3;
        List<hole> holes = new List<hole>();
        List<hole> segments = new List<hole>();
        memory mem;
        List<process> processes= new List<process> ();
        int num_of_process;
        Color[] colors;
        private Form7(List<hole> ha,List<hole> s,List<process> pa,int n,int op)
        {
            holes = s;
            segments = s;
            processes = pa;
            num_of_process = n;
            InitializeComponent();

            

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
            if (op == 1) trans();
            else Draw();
        }
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
                processes.Add(p);
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
            if (Form1.type_of_algorithm == 1)
            {
                schedular1 = new firstfit(holes, processes);
                schedular1.First_Fit_Algorithm();
                segments = schedular1.holes;
               
            }
            else if (Form1.type_of_algorithm == 2)
            {
                schedular3 = new bestfit1(processes, holes);
                
                segments = schedular3.output_memory;

            }
            else if (Form1.type_of_algorithm == 3)
            {
                schedular2 = new worstfit(holes, processes);
                schedular2.computeWorstFit();
                segments = schedular2.holes;
                //ShowDialog4(schedular2.holdProcesses);
            }
            Draw();
        }
        void trans()
        {
            if (Form1.type_of_algorithm == 1)
            {
                schedular1 = new firstfit(holes, processes);
                schedular1.First_Fit_Algorithm();
                segments = schedular1.holes;

            }
            else if (Form1.type_of_algorithm == 2)
            {
                schedular3 = new bestfit1(processes, holes);

                segments = schedular3.output_memory;

            }
            else if (Form1.type_of_algorithm == 3)
            {
                schedular2 = new worstfit(holes, processes);
                schedular2.computeWorstFit();
                segments = schedular2.holes;
                ShowDialog4(schedular2.holdProcesses);
            }
            Draw();
        }
        

        /*for integration:
         * awl 7aga 3ndak list of holes de feha al holes
         * 3ndak list of process de feha processes we feha kaman enak ama hat3ml add process hattzawed 3leha 
         * 3ndak function esmaha draw bttnedeh awl ma btfta7 al form de 
         * ana 3awzak abl ma tndaha t3mel alkalam da:
         *       tshoof al var aly esmo Form1.type_of_algorithm
         *                  law be 1 m3anaha First fit 7ot al code bta3o 
         *                  law be 2 yb2a bist 
         *                  law 3 yb2a worest
         *       b3d ma 3rft t7aded al algorithm abl ma tndah draw ba2a 7ot function aktebha anta bta5od al holes we al processes lists
         *       we btraga3ly al List aly asmaha segments 
         *       ana harsem aly mawgood gwa segments we isa ytl3 sa7 
         *       mafeesh deallocation at3amal lesa 
         *       zabat anta azay hat integrate 
         *       malaksh da3aw be al functions aly esmaha drawdialog we alkalam da 
         * shed 7elak ya negm rabna ywafa2ak 
         * 
         * 
         * 
         * ah sa7ee7 shoof awl comment fe dunction draw()
         */


        void Draw() {

            //lazem t8ayar kelmet holes aly fe alsatr aly t7t da le segments 3shan yrsem al output mayrsemsh 7aga tanya 
            mem = new memory(segments);

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
            for (int i = 0; i < mem.segments.Count; i++)
            {
                if (i + 1 < mem.segments.Count&& mem.segments[i].start == mem.segments[i + 1].start) continue;
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
                    l2.Text = "P" + (mem.segments[i].process_index ).ToString() + ": " + mem.segments[i].name;
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
            num_of_process++;
            int promptValue = Form7.ShowDialog("Number Of Segments", "enter no of segments");
            process p=Form7.ShowDialog2("enter process data", "new process",promptValue,num_of_process);
            //num_of_process++;
            processes.Add(p);
            Form7 form = new Form7(holes,segments,processes,num_of_process,1);
            form.Show();
            Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<process> p = ShowDialog3();
            worstfit t = new worstfit(segments, p);
            t.deallocator();
            segments = t.holes;
            Form7 form = new Form7(holes, segments, processes, num_of_process,2);
            form.Show();
            Hide();

        }
        bool is_there(int n,List<process> p)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if (p[i].process_id == n) return false;
            }
            return true;
        }
        private List<process> ShowDialog3()
        {
            List<process> pr = new List<process>();
            for(int i = 0; i < segments.Count; i++)
            {
                if (segments[i].alocated == true)
                {
                    if (is_there(segments[i].process_index, pr))
                    {
                        pr.Add(new process(segments[i].process_index, 1));
                    }
                }
            }
            Form prompt = new Form();
            prompt.Width = 600;
            prompt.Height = 600;
            prompt.AutoScroll = true;
            prompt.Text = "deallocator";
            Label[] values = new Label[pr.Count];
            CheckBox[] names = new CheckBox[pr.Count];
            prompt.BackColor = Color.MistyRose;
            Label textLabel = new Label() { Left = 50, Top = 64, Width = 200, Height = 41, Text = "deallocator", BackColor = Color.Gray, Font = new Font("Segoe UI", 14F) };
            //===============================
            Label num_oldd = new Label();
            num_oldd = new Label() { Left = 100, Top = 123, Width = 89, Font = new Font("Segoe UI", 14F), Height = 50, BackColor = Color.Bisque, Visible = true, ForeColor = Color.Black };
            num_oldd.Enabled = true;
            int y = 60;
            int m = num_oldd.Location.Y;
            for (int j = 0; j < pr.Count; j++)
            {
                Label numd = new Label();
                numd.Size = num_oldd.Size;
                numd.Text = pr[j].process_id.ToString();
                numd.TextAlign = num_oldd.TextAlign;
                numd.Location = new Point(num_oldd.Location.X, num_oldd.Location.Y + y - 60);
                numd.Enabled = num_oldd.Enabled;
                numd.BackColor = num_oldd.BackColor;
                numd.Font = num_oldd.Font;
                numd.TextAlign = num_oldd.TextAlign;
                values[j] = numd;
               
                prompt.Controls.Add(numd);
                y = y + 60;
            }
            //===============================
            CheckBox num_ol = new CheckBox();
            num_ol.Enabled = true;
            int yy = 60;
            for (int j = 0; j < pr.Count; j++)
            {
                CheckBox n = new CheckBox();
                n.Size = num_ol.Size;
                n.TextAlign = num_ol.TextAlign;
                n.Location = new Point(num_oldd.Location.X + 100, m + yy - 60);
                n.Enabled = num_ol.Enabled;
                n.BackColor = num_ol.BackColor;
                n.Font = num_ol.Font;
                n.TextAlign = num_ol.TextAlign;
                
                names[j] = n;
                prompt.Controls.Add(n);
                yy = yy + 60;
            }
            List<process> pt = new List<process>();
            Button confirmation = new Button() { Text = "Ok", Left = 100, Top = yy + 50, ForeColor = Color.DodgerBlue, Width = 88, Height = 46, BackColor = Color.Aquamarine };
            confirmation.Click += (sender, e) => {
                
                for(int j = 0; j < pr.Count; j++)
                {
                    if (names[j].Checked)
                    {
                        pt.Add(pr[j]);
                    }
                }
                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
            return pt;

        }
        private void ShowDialog4(List<process> a)
        {
            
            Form prompt = new Form();
            prompt.Width = 600;
            prompt.Height = 600;
            prompt.AutoScroll = true;
            prompt.Text = "processes not allocated in memory";
            Label[] values = new Label[a.Count];
           
            prompt.BackColor = Color.MistyRose;
            Label textLabel = new Label() { Left = 50, Top = 64, Width = 200, Height = 41, Text = "process", BackColor = Color.Gray, Font = new Font("Segoe UI", 14F) };
            //===============================
            Label num_oldd = new Label();
            num_oldd = new Label() { Left = 100, Top = 123, Width = 89, Font = new Font("Segoe UI", 14F), Height = 50, BackColor = Color.Bisque, Visible = true, ForeColor = Color.Black };
            num_oldd.Enabled = true;
            int y = 60;
            int m = num_oldd.Location.Y;
            for (int j = 0; j < a.Count; j++)
            {
                Label numd = new Label();
                numd.Size = num_oldd.Size;
                numd.Text = a[j].process_id.ToString();
                numd.TextAlign = num_oldd.TextAlign;
                numd.Location = new Point(num_oldd.Location.X, num_oldd.Location.Y + y - 60);
                numd.Enabled = num_oldd.Enabled;
                numd.BackColor = num_oldd.BackColor;
                numd.Font = num_oldd.Font;
                numd.TextAlign = num_oldd.TextAlign;
                values[j] = numd;

                prompt.Controls.Add(numd);
                y = y + 60;
            }
            //===============================
            CheckBox num_ol = new CheckBox();
            num_ol.Enabled = true;
            int yy = 60;
            
            List<process> pt = new List<process>();
            Button confirmation = new Button() { Text = "Ok", Left = 100, Top = y + 50, ForeColor = Color.DodgerBlue, Width = 88, Height = 46, BackColor = Color.Aquamarine };
            confirmation.Click += (sender, e) => {

                
                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();
           

        }
    }
}
