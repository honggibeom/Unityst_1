using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;
    void Damage(int _HP) 
    {
        HP = HP - 10;
    }

    public int Plus(int a, int b)
    {
        return a + b;
    }
}

namespace _09.Operator
{
    class Program
    {

        static void Main(string[] args)
        {
            Player newplayer = new Player();
            //= 대입 연산자, 값(리턴값 등)을 변수에 대입
            int result = 0;
            int lef = 7;
            int rig = 3;
            //산술 연산자 
            result = newplayer.Plus(lef , rig); //더하기
            result = lef +  rig;
            result = lef - rig; //빼기
            result = lef * rig; //곱하기
            result = lef / rig; // 나누기
            result = lef + rig; //더하기
            result = lef % rig; //나머지
                                //나누기. 나머지 연산할때 0주의

            //연산자는 함수와 비슷
            //비교연산자 -> 논리형 리턴
            //논리형 -> bool, 참 거짓
            bool Bresult = true;
            Bresult = false;

            Bresult = lef > rig; 
            Bresult = lef < rig;
            Bresult = lef <= rig;
            Bresult = lef >= rig;
            Bresult = lef == rig;
            Bresult = lef != rig;


            //bool 논리 연산자 
            Bresult = true && false;//AND 
            Bresult = true || false;//OR
            Bresult = true ^ false;//XOR 양쪽이 다르면 true
            Bresult = !true;//NOT

            //축약연산자
            result += 10;//result= result+10
            result -= 10;// result=result-10
            result *= 10;//result= result*10
            result /= 10;//result= result/10
        }
    }
}
