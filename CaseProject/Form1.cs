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
        private  Robot r;
        private Robot r2;
        private  Graphics g;
        private Controls controls;
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Size = Start.rec.Size;
            r = new Robot(Start.rec.X, -1*(Start.rec.Y-(Start.rec.Height-120)), 30, 60);
            r2 = new Robot(400, 400,30,60);
            r2.isDone = true;
            r2.firstLocation = r2.firstLocation;
            r.firstLocation = r.location;
            this.BackColor = Color.MintCream;
            label1.Text = r.state.ToString();
            label3.Text = (r.location.X).ToString();
            label2.Text = ((Size.Height-r.location.Y)-120).ToString();
            controls = new Controls();
       
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar==(char)Enums.LEFT || e.KeyChar == (char)Enums.RIGHT)
            {
                controls.setState(r, e.KeyChar);
                controls.setState(r2, e.KeyChar);
                Debug.WriteLine(r.state);
                g.Clear(Color.MintCream);
            }
            if (e.KeyChar== (char)Enums.MOVE)
            {
                r.location = controls.move(r);
               
                if (r.location==r.firstLocation&&r2.isDone)
                {
                   
                    Debug.WriteLine(r2.location.X);
                    Debug.WriteLine(r2.location.Y);
                    Debug.WriteLine("Konum uyuştu");
                    controls.roList.currentNode = controls.roList.firstNode;
                    r.isDone = true;
                    r2.isDone = false;
                }
                else
                {
                    r2.location = controls.move(r2);
                }
            }
            g.Clear(Color.MintCream);
            RotateRectangle(g, r2.buildRobot(), r2.angle);
            RotateRectangle(g, r.buildRobot(), r.angle);
            Debug.WriteLine(r.location.X);
            label1.Text = r.state.ToString();
            label6.Text = r2.state.ToString();
            label3.Text = (r.location.X).ToString();
            label2.Text = ((Size.Height - r.location.Y) - 120).ToString();
            label4.Text = (r.location.X).ToString();
            label5.Text = ((Size.Height - r.location.Y) - 120).ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
            RotateRectangle(g, r2.buildRobot(), 0);
            RotateRectangle(g, r.buildRobot(), 0);
        }
    }
}
