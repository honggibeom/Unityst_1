using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Item{ 

}

class MyList<T> {

    int[] Arr = new int[0];
    int Capa = 0;
    int Count = 0;
    public void Add(T _Add) {
        if (Count + 1 > Capa) { 
            

        }
    
    }

}
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열형, 시퀸스
            //내가 관리해달라고 요청하는것이 매번 바뀌는것
            //그러므로 제네릭 클래스여야 한다.
            List<int> NewList = new List<int>();
            List<Item> NewList1 = new List<Item>();
            for(int i =0; i<10; i++) {

                Console.WriteLine((NewList.Count+1).ToString()+"  ADD" );//자료의 크기
                Console.WriteLine("Capa:  " + NewList.Capacity);//배열의 크기
                Console.WriteLine("Count: " + NewList.Count);//자료의 크기
                NewList.Add(i);        
            }
            //내부에 자료 존재여부
            if (NewList.Contains(8)) {

                Console.WriteLine("내부에 8이 있습니다.");
            }
            if (NewList.Contains(999999))
            {

                Console.WriteLine("내부에 9999999이 있습니다.");
            }
            else 
            {
                Console.WriteLine("내부에 9999999이 앖습니다.");
                
            }
            //인덱서/연산자 겹지정이라 부름
            Console.WriteLine(NewList[5]);

            NewList.Remove(10);//10이 있다면 지움
            NewList.RemoveAt(1);//1번째를 지움
            //NewList.RemoveAll 중복되면 지움
            NewList.RemoveRange(0, 2);//0번째 에서부터 2개를 지움
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(NewList[i]);
            }
        }
    }
}
