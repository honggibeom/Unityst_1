using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자식에서 함수를 재구현했으면 자식의 것으로 호출(다형성)
class FightUnit {
    
    protected string name = "None";
    protected int AT =10;
    protected int HP =100;

    //추상화
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GETAT");
        return AT;
    }
    public void Damage(FightUnit _OtherFightUnit) {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.name+ _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }

}

class Player: FightUnit
{

    int ItemAt = 5;
    //오버라이딩
    public override int GetAT()
    {
        Console.WriteLine("플레이어의 GETAT");
        return AT + ItemAt;
    }
    public Player(string _Name) {

        name = _Name;
    }
}

class Monster : FightUnit
{

    int MonsterLv = 5;
    public override int GetAT()
    {
        Console.WriteLine("몬스터의 GETAT");
        return AT+MonsterLv;
    }
    public Monster(string _Name)
    {
        name = _Name;

    }
}

namespace _30.Overraidong
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");
            Newplayer.Damage(NewMonster);
            NewMonster.Damage(Newplayer);
        }
    }
}
