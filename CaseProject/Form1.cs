using CaseProject.Robots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject
{
    public partial class Form1 : Form
    {
        private Robot r1;
        private Robot r2;
        private int X;
        private Point p;
        public Form1()
        {
            InitializeComponent();
            r1 = new Robot(new Size(30,60),new Point(0,0));
            r2 = new Robot();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r1.BackColor = Color.Aqua;
            
            Controls.Add(r1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = r1.Location;
            p.X += 5;
            r1.Location = p;
        }


       
    }
}
