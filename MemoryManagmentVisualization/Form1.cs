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
    public partial class Form1 : Form
    {

        public static int total_memory_size=1;
        public static int no_of_holes = 1;
        public static int no_of_processes = 1;

        public static int[] holes_start_adress;
        public static int[] holes_sizes;

        public static int[] no_of_segments;

        public static String[] name_of_segments;
        public static int[] size_of_segments;

        public static int type_of_algorithm=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            Hide();
        }
    }
}
