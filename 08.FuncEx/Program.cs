using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Player
{
    //접근제한 지정자를 입력하지않으면
    //디폴트로 private
    //private이 일반적임
    //속성들은 외부에서 접근하지 못하는게 좋음
    int AT = 10;
    int HP=100;
    int LV = 1;
    //상태라는건 맴버변수
    //어떤 상태가 변화하는 순간
    //함수로 한번에 증가시키는게 깔끔함
    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }
    public int GetLV()
    {
        //외부에 (리턴값)상태를 알려주면서 함수 종료
        return LV;
    }
    public void setHP(int _HP)
    {
        //HP가 0이 되는 순간만 체크가능
        //100이되는 순간만 체크가능
        //가장 중요한점은 디버깅이됨
        HP = _HP;
    }
    // 함수는 보통 클래스외부와의 소통을  위해서 만듬

    //함수는 선언과 내용으로 나뉨
    public void Dmg1(int _Dmg)
    {
        HP = HP - _Dmg;
    }
    public void Dmg2(int _Dmg, int subdmg)
    {
        HP = HP - _Dmg - subdmg;
    }
    
    //리턴값은 자신이 리턴해주려는 자료형과
    //동일한 자료형 이어야함
    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }
}//플레이어가 어떤 사양과 내용을 가졌다. 
namespace _08.FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //외부의 값을 받아서 객체가 내부의 상태를
            //변화시키기 위해서 함수선언을 많이함
            NewPlayer.LVUP();
            NewPlayer.Dmg1(10);
            NewPlayer.Dmg2(10,20);
            Console.WriteLine(NewPlayer.GetLV());
            NewPlayer.setHP(300);
            Console.WriteLine(NewPlayer.DamageToHPReturn(50));
        }
    }
}
