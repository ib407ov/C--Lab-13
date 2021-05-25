using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Resault:    ";
            toolStripStatusLabel2.Text = "";
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lenghtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] arr = new double[2];
            TCone m = new TCone(textR1.Text, textR2.Text);
            arr = m.lenght();
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text =  "l1 = " + arr[0] + " l2 = " + arr[1];
        }

        private void radiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] arr = new double[2];
            TCone m = new TCone(textR1.Text, textR2.Text);
            arr = m.Radius();
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text = "l1 = " + arr[0] + " l2 = " + arr[1];
        }

        private void comprasionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCone m = new TCone(textR1.Text, textR2.Text);
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text = m.comprasion().ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TCone m = new TCone(textR1.Text, textR2.Text);
            TCone l = new TCone(textR1.Text, textR2.Text);
            TCone cone1 = new TCone(l + m);
            TCone cone2 = l + m;
            textR1.Text = cone1.ToString();
            textR2.Text = cone2.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSphere l = new TSphere(textR1.Text, textR2.Text);
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text = l.Square()[0].ToString() + ", " + l.Square()[1].ToString();
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSphere l = new TSphere(textR1.Text, textR2.Text);
            toolStripStatusLabel1.Text = "Result : ";
            toolStripStatusLabel2.Text = l.Volume()[0].ToString() + ", " + l.Volume()[1].ToString();
        }
    }
}
