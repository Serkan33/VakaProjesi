using CaseProject.LinkedList;
using CaseProject.Robots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject
{
    public partial class Form1 : Form
    {
        private static Robot r;
        private static Graphics g;
        private Controls controls;
        public static Size size; 
        public Form1()
        {
            InitializeComponent();
            r = new Robot(50, 50, 30, 60);
            r.firstLocation = r.location;
            r.state = (char)Enums.NORTH;
            this.BackColor = Color.MintCream;
            controls = new Controls();
            size = Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g=this.CreateGraphics();
            RotateRectangle(g, r.buildRobot(), 0);
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            g.Clear(Color.MintCream);
            if (e.KeyChar==(char)Enums.LEFT || e.KeyChar == (char)Enums.RIGHT)
            {
                controls.setState(r, e.KeyChar);
                Debug.WriteLine(r.state);
            }
            if (e.KeyChar== (char)Enums.MOVE)
            {
                r.location = controls.move(r);   
                if(r.location==r.firstLocation)
                {
                    Debug.WriteLine("Konum uyuştu");
                    r.isDone = true;
                }
                RotateRectangle(g, r.buildRobot(), r.angle);
            }
            RotateRectangle(g, r.buildRobot(), r.angle);
        }

        public void RotateRectangle(Graphics g, Rectangle r, float angle)
        {

            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawRectangle(Pens.Black, r);
                g.ResetTransform();
            }
        }
        
    }
}
