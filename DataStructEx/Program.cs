using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GTest<T> {

    T Data;

}
namespace System {

    namespace Collections {

        namespace Generic {

            struct MyTest<TKey, TValue> { 
            
            }        
        }     
    }
}

namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            //순회방식사용하는것이 좋음
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);

            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            System.Collections.Generic.MyTest<int, int> Test;
            // var 그시점에서 가장알맞은 자료형이 되어줌

            //foreach 는 자동적으로 반복하는 문장으로서
            //in을 통해서 각 배열이든 딕셔너리든 리스트 
            //내부의 자료를 그대로 순회할수 있게 처리해 준다.
            //var은 그때의 가장 적합자료형으로 처리된다.
            //in은 자료구조에서 빼온다 대신 루프제한이 어려움
            foreach (var item in ListTest) {

                Console.WriteLine(item);           
            }

            foreach (var item in LinkedListTest)
            {

                Console.WriteLine(item);
            }

            foreach (var item in DicTest)
            {

                Console.WriteLine(item.Key);
            }
        }
    }
}
