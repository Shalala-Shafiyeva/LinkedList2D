using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2D
{
    public class LinkedList2D<T>
    {
        public Node<T> head { get; set; }
        public Node<T> tail { get; set; }
        public int count { get; set; }

        public LinkedList2D()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public LinkedList2D(T data)
        {
            Node<T> newNode = new Node<T>(data);

            head = newNode;
            tail = newNode;
            count = 1;
        }
        public void AddNodeToBeginning(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                count++;
            }
            else
            {
                head.Previous = newNode;
                newNode.Next = head;
                head = newNode;
                count++;
            }

        }
        public void AddNodeToEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                count++;
            }
            
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
                count++;
            }
        }
        public void Output()
        {
            Node<T> runner = head;
            while (runner != null)
            {
                Console.Write(runner.Data + " ");
                runner = runner.Next;
            }
        }

        public Node<T> FindMinNode()
        {
            Node<T> MinNode = head;
            Node<T> runner = head;
            while (runner != null)
            {
                if (Convert.ToInt32(runner.Data) < Convert.ToInt32(MinNode.Data)) MinNode = runner;
                runner = runner.Next;
            }
            return MinNode;
        }

        public Node<T> FindNode(T target)
        {
            
            Node<T> currentNode = head;
            while(currentNode!=null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
                
            }
            return currentNode;
            
        }

        public void AddRange(LinkedList2D<T> linkedList)
        {
            LinkedList2D<T> newLinkedList = CopyList(linkedList);

            tail.Next = newLinkedList.head;
        }

        public static LinkedList2D<T> CopyList(LinkedList2D<T> linkedList)
        {
            LinkedList2D<T> newLinkedList = new LinkedList2D<T>();

            Node<T> runner1 = linkedList.head;
            Node<T> runner2 = newLinkedList.head;
            runner2.Data = runner1.Data;

            while (runner1.Next != null)
            {
                runner2.Next = new Node<T>(runner1.Next.Data);

                runner1 = runner1.Next;
                runner2 = runner2.Next;
            }

            return newLinkedList;
        }

    }
}
