
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList2D<int> linkedList2d = new LinkedList2D<int>();

            linkedList2d.AddNodeToEnd(1);
            linkedList2d.AddNodeToEnd(2);
            linkedList2d.AddNodeToEnd(-3);
            linkedList2d.AddNodeToEnd(155);
            linkedList2d.AddNodeToEnd(48);
            linkedList2d.AddNodeToEnd(9);
            
            
            linkedList2d.Output();
            Console.WriteLine();

            linkedList2d.AddNodeToBeginning(66);
            linkedList2d.AddNodeToBeginning(7);
            linkedList2d.Output();

            Console.WriteLine();

            Node<int> minEl = linkedList2d.FindMinNode();
            Console.WriteLine(minEl.Data);

            //doublyLinkedList.RemoveNodeWithData(-5);



            List<int> list = new List<int>();
                                              
            Console.ReadKey();
        }
    }
}
