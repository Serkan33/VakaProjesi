using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject
{
    
    public partial class Start : Form
    {
        public static Rectangle rec;
        public Start()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string [] rightCorner = rightCornTxt.Text.Split(' ');
            string[] coord = robotInitCoorTxt.Text.Split(' ');
            if(!inputControl(rightCornTxt.Text.Trim())|| !inputControl(robotInitCoorTxt.Text.Trim()))
            {
                MessageBox.Show("Değerler sayı olmalı ve aralarında birer boşluk olmalı!");
            }
            else
            {
                rec = new Rectangle(new Point(int.Parse(coord[0]), int.Parse(coord[1])), new Size(int.Parse(rightCorner[0]), int.Parse(rightCorner[1])));
                new Form1().Show();
            }
        }

        private bool inputControl(string input)
        {
            Regex regex = new Regex(@"[0-9]+ [0-9]+$");
            Match match = regex.Match(input);
            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}
