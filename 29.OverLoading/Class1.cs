using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG,
}
class Player
{
    int FireDef=5;//불방어
    int IceDef=5;//물방어
    int AttDef=5;//물리방어
    int Hp = 100;
    //생성자, static 함수도 가능
    //함수 오버로딩,이름같아도 매개변수가 같으면 다른함수로 인식
    //Damage float int
    public Player()
    {

    }
   public Player(int _Hp) {

        Hp = _Hp;
    }

    public void Damage(float _Damage, int _Type)
    {

    }
    //Damage int int
    public void Damage(int _Damage, DMGTYPE _Type)
    {
       switch(_Type){

            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            default:
                break;


        }
        Damage(_Damage);
    }
    //Damage int  
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }

}

namespace _29.OverLoading
{
    class Class1
    {
        static void Main(string[] agrs) { 
        Player Newplayer = new Player();
        Newplayer.Damage(100,DMGTYPE.FIREDMG);
        }
}
}
