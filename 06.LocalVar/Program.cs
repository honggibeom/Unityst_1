using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Player
{
    int Att;
    int Hp;

   void Fight() 
    {
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다");
    }
}// 설계도
namespace _06.LocalVar
{
    //C#은 고지식한 객체지향 언어
    //시작조차도 클래스안에 묶어놔야함
    class Program
    {
        //시작용 함수
        static void Main(string[] args)
        {
            //클래스 안에 있으면 멤버변수
            // 함수안에 잇는 녀석들은 지역변수
            // 지역변수 규칙 1. 
            //{
            //       내부에서만 사용가능
            //}
            int a=0;
            //Player의 설계대로 플레이어를 만드는데
            // 이름은 NewPlayer라고 해라
            Player NewPlayer = new Player();
        }
    }
}
