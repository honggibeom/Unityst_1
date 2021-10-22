using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Arrary
{
    class Program
    {

        class Item
        {
            public string Name;
            int AT;
            int DF;

        }



        static void Main(string[] args)
        {
            //배열은 기본 자료형에 속함
            //선언방식은 자료형[]
            //모든 자료형은 구조체 아니면 클래스에 가까움
            //기본자료형도 마찬가지임(멤버변수, 멤버 함수를 가짐)
            //구조체에 가까움
            //여러개가 모여있는것, 자료접근방법
            //[0][0][0][0][0][0][0][0][0][0][0]
            int[] ArrInt = new int[10];

            //ArrInt int의 배열형
            //Arrint[0]은 int 형
            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrInt[0]);
            }
            //아이템이라는 참조형을 담을수있는 공간 10개 생성
            Item[] ArrItem = new Item[10];
            //아이템 10개 생성
            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
            }
            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "전설의 검";
            ArrItem[2].Name = "갑옷";
            ArrItem[3].Name = "멋진갑옷";
            ArrItem[4].Name = "포션";

            for (int i = 0; i < ArrItem.Length; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }
        }
    }
}
