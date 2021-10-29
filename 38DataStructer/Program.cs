using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyDataStructer<T> {
    //넣기
   public void Push(T _Data) { }
    //찾기
    public void Find(T _Data) { }
    public  void EX(int size) { }

}
//시퀀스 컨테이너(List,vector(c#에서는 없음))
//연관컨테이너(Dictionary(해쉬맵))
//어뎁터 컨테이너(stack,queue) 

//데이터의 메모리 구조는
//노드,배열이있음
namespace _38DataStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDataStructer<int> MDS = new MyDataStructer<int>();
            MDS.Push(500);//500넣기
            MDS.EX(56);//사이즈 56으로 늘리기
            MDS.Find(500);//500찾기
        }
    }
}
