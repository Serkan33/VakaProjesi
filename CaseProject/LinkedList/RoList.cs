using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.LinkedList
{

    // Linked list for direction control
    class RoList
    {
        public RotationNode firstNode { set; get; }
        public RotationNode currentNode { set; get; }
        public RotationNode lastNode { set; get; }
        public bool isNext { set; get; }
        public RoList(RotationNode rotationNode)
        {
            firstNode = rotationNode;
            currentNode = rotationNode;
            lastNode = rotationNode;
            isNext = false;
        }


        public void addNode(RotationNode rotation)
        {
            if (currentNode.next == null)
            {
                currentNode = currentNode.next = rotation;
                lastNode = rotation;
            }
        }

        public bool nextNode()
        {
            if (!isNext)
                currentNode = firstNode;

            if (currentNode.next != null)
            {
                currentNode = currentNode.next;

                isNext = true;
                return true;
            }

            isNext = false;
            return isNext;
        }
    }
}
