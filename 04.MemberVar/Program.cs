using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//보통 한글 안씀(쓰기는 가능)
//영어로 코드룰 쳤기 때문에 한글 처리가 미흡함


//게임을 만들게 되면 
//큰개념

//Rpg
//플레이어가 가질수 있는 세부적인 내용?
//Gold
//공격력
//
//명사로 표현되는 것들 대부분 맴버 변수
//status는 큰개념


//개념: 플레이어 존재
class Player
{
    //내용을 채움

    // 맴버변수 선언
    // int (자료형) 이름(식별자)
    //초기값(리터럴값) 설정 가능
    //선언과 동시에 값을 넣어주는것-> 리터럴 초기화

    //프로그램을 실행하면  램에 프로그램이 복사가됨
    //1.공짜가 없다(메모리) .



    //자료형의 의미
    //크기 : 4바이트
    //형태 : 정수
    //이름의 의미
    //위치
    //내가 사용하기 위한 별명
    //Gold ->51563(위치로 변환)
    //Att ->90(위치로 변환)
    //int Att -> 램의 30번지에 4바이트 공간을 할당
    //=300 -> 30번지에 300이라는 값을 넣는다.

    //규칙이나 물리법칙
    //300은 상수(불변)

    int Gold =10;
    int Exp=1000;
    int Att=300;
 
}

namespace _04.MemberVar
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
