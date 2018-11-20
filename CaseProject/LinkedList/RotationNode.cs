using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.LinkedList
{
    class RotationNode
    {
        public RotationNode next { set; get; }
        public RotationNode prev { set; get; }
        public char state { set; get; }

        public RotationNode(char s, RotationNode pre)
        {
            state = s; 
            prev = pre;
        }
    }
}
