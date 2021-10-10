using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Player
{
    //객체지향의 캡슐화 은닉화를 대표하는 문법
    //"접근제한 지정자"
    // 종류
    public int Att; //전부공개
    protected int Hp;//자식에게만 공개
    private int DEF;//내부에게만 공개 

    public void Fight()
    {
        int Damage = 0;
        Console.WriteLine("싸운다");
    }
}
namespace _07.ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // 만들어진 객체의 내용을 사용하기 위해서는
            //객체의 이름.을 사용한다.
            //접근제한 지정자를 사용하지 않으면 외부에 공개 x
            Player NewPlayer = new Player();
        }
    }
}
