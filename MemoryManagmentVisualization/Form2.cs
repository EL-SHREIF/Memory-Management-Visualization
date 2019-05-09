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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numeric_numProcess.Value = Form1.total_memory_size;
            numericUpDown1.Value = Form1.no_of_holes;
            numericUpDown2.Value = Form1.no_of_processes;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1.total_memory_size = (int)numeric_numProcess.Value;
            Form1.no_of_holes = (int)numericUpDown1.Value;
            Form1.no_of_processes = (int)numericUpDown2.Value;
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            Form1.total_memory_size = (int)numeric_numProcess.Value;
            Form1.no_of_holes = (int)numericUpDown1.Value;
            Form1.no_of_processes = (int)numericUpDown2.Value;
           
                Form3 form = new Form3();
                form.Show();
                Hide(); 
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
