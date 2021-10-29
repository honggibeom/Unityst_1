using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //시퀸스 배열형 List
            //시퀸스 노드형 LinkedList
            LinkedList<int> LList =new LinkedList<int>();
            
            LList.AddFirst(10);
            LList.AddFirst(20);
            LList.AddFirst(33);
            //LList.AddLast(33);
            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;

            LList.AddAfter(Cur, 33);

            LList.Remove(10);
            LList.RemoveFirst();
            LList.RemoveLast ();
            for (LinkedListNode<int> StartNode = LList.First;
                StartNode!=null ; StartNode=StartNode.Next) {
               
                Console.WriteLine(StartNode.Value);
               
            }

            for (LinkedListNode<int> StartNode = LList.Last;
            StartNode != null; StartNode = StartNode.Previous)
            {

                Console.WriteLine(StartNode.Value);

            }
            //모두 지우기
            LList.Clear();


        }
    }
}
