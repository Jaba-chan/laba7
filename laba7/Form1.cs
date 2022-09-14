using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class Form1 : Form
    { 
        static int[] Q = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
             for (int i = 0; i < Q.Length; i++)
            {
                Q[i] = rnd.Next(1, 1000);
                listBox1.Items.Add(Q[i]);
            }
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            for (int i = 0; i < Q.Length; i++)
            {
                if (Q[i] % 7 == 1 || Q[i] % 7 == 2 || Q[i] % 7 == 5)
                {
                    listBox2.Items.Add(Q[i]);
                }
            }
        }
    }
}
