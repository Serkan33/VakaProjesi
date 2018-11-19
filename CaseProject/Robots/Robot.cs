using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseProject.Robots
{
    class Robot : Panel
    {
       
        public Robot() { }
        public Robot(Size size,Point point) {
            this.Size = size;
            this.Location = point;
        }
    }
}
