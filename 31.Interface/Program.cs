using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//사용자 정의 자료형
interface QUESTUnit {

    //멤버변수x
    //int a=0;

    //함수의 형태만 물려줄수 있는 문법
    void Talk(QUESTUnit _OtherUnit);
    void Event(QUESTUnit _OtherUnit);
}

interface QUESTUnit2
{

    //멤버변수x
    //int a=0;

    //함수의 형태만 물려줄수 있는 문법
    void Talk(QUESTUnit _OtherUnit);
    void Event(QUESTUnit _OtherUnit);
}
class FightUnit
{

    protected string name = "None";
    protected int AT = 10;
    protected int HP = 100;
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GETAT");
        return AT;
    }
    public void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.name + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }

}
//인터페이스는 함수 구현을 강제 할 수 있다.
//인터페이스는 상송보다 포함의 개념
class Player:FightUnit, QUESTUnit
{
    public void Talk(QUESTUnit _OtherUnit) { 
    
    }
    public void Event(QUESTUnit _OtherUnit) { 
    
    }
}

class NPC :FightUnit, QUESTUnit
{
    public void Talk(QUESTUnit _OtherUnit)
    {

    }

    public void Event(QUESTUnit _OtherUnit)
    {

    }
}


namespace _31.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            NPC NewNPC = new NPC();

            QUESTUnit NewQUESTUnit = NewNPC;
            //업캐스팅
            NewPlayer.Talk(NewNPC);
            NewPlayer.Talk(NewPlayer);
        }
    }
}
