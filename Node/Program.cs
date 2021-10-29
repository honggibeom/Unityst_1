using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Room { 

//연결되어있는 방을 구현할때 자주사용함
}


class Node<T> {

    public T Data;
    //자신을 또 가지는 형태
    public Node<T> Next = null;
    public Node<T> Prev = null;
    public Node(T _Data) {
        Data = _Data;
    }
}


namespace Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Node1 = new Node<int>(10);
            Node<int> Node2 = new Node<int>(999);
            Node<int> Node3 = new Node<int>(578);

            Node1.Next = Node2;
            Node2.Next = Node3;

            Node3.Prev = Node2;
            Node2.Prev = Node1;

            Node<int> CurNode = Node1;
            while (CurNode != null) {
                Console.WriteLine(CurNode.Data);
                CurNode = CurNode.Next;
            }

            Node<int> RCurNode = Node1;
            while (CurNode != null)
            {
                Console.WriteLine(RCurNode.Data);
                RCurNode = RCurNode.Prev;
            }
        }
    }
}
