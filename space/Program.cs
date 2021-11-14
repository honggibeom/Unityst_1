using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Monster{
    int monAlive = 1;
    int x, y;
    public Monster(int x, int y) { this.x = x; this.y = y; }

    public void Monattacked() {

        monAlive = 0;

    }

    public bool Mondead()
    {
            if (monAlive == 1)
                return false;
        return true;
    }
     
    public void Move()
    {
        if (y % 2 == 1)
            x++;
        else
            x--;
        if (x == 64)
        {
            x = 63;
            y++;
        }
        else if (x == -1) 
        {
            x = 0;
            y++;
        }
    }
   // public bool isattacked(bullet b) { 
        

    
    //}
    public int getX() { return x; }
    public int getY() { return y; }

}
class bullet{
    int x, y = 29;
    public bullet(int x) { this.x = x; }
    public bool isbullet(int x, int y)
    {
        if (this.x == x && this.y == y)
            return true;
        return false;
    }
    public void Move()
    {
        y--;
    }

    public bool attack(Monster m) {
        if (m.getX() == x && m.getY() == y)
            return true;
        return false;
    }

    public int getX() { return x; }
    public int getY() { return y; }
}



class Player{
    int x, y=30;
    public Player(int x) { this.x = x;}
    public bool isPlayer(int x, int y)
    {
        if (this.x == x && this.y == y)
            return true;
        return false;
    }

    public void Move(ConsoleKey a)
    {
        switch (a)   // switch 문으로 경우의 수를 나눔
        {
            case ConsoleKey.LeftArrow:
                if (x > 0)
                    x--;
                break;
            case ConsoleKey.RightArrow:
                if (x < 63)
                    x++;
                break;
        }
    }
    public int getX() { return x; }
    public int getY() { return y; }
}

class Map {

    Player player = new Player(0);
    Monster[][] mon = new Monster[4][];
    bullet[] b = new bullet[100];
    public void Setmon(){
        mon[0] = new Monster[12];
        mon[1] = new Monster[12];
        mon[2] = new Monster[12];
        mon[3] = new Monster[12];
        for (int i =0; i < 12; i++) { 
         mon[0][i] = new Monster(i,1);
         mon[1][i]= new Monster(i,3);
         mon[2][i]= new Monster(i,5);
         mon[3][i]= new Monster(i,7);
        }
    }
    int gameover() {
        
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 12; j++) {
                if (mon[i][j].Mondead() == true)
                    continue;
                else
                {
                    if (mon[i][j].getY() == 29)
                        return -1;

                    return 0;
                }
            }
        }
        return 1;
    }
        


    public string[] Setmap() {
        string []map1 = new string[32];
        char[][] map = new char[32][];
        for (int i = 0; i < 32; i++) { map[i] = new char[64]; }
        map[player.getY()][player.getX()]='△';
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 12; j++)
            {
                 if (mon[i][j].Mondead() == false)
                       map[mon[i][j].getY()][mon[i][j].getX()] = '◇';
            }
        }
        for (int i = 0; i < 100; i++)
        {
            if(b[i]!=null)
            map[b[i].getY()][b[i].getX()] ='▲' ;       
        }

        for(int i = 0; i < 32; i++) { 
            for (int j = 0; j < 64; j++)
            {
                if (map[i][j] == '\0')
                    map[i][j] = ' ';
                map1[i] += map[i][j];
            }
        }
        return map1;
    }
 
    public void printMap() {
        string []map = Setmap();
        Console.WriteLine("\n\n\n\n");
        for (int i = 0; i < 32; i++) {
                Console.WriteLine("\t\t\t"+map[i]);
        }
        Console.WriteLine("\n\n");
        Console.WriteLine("\t\t점수:  \n\t\t체력:   ");
    }

    public void play()
    {
        int gameover=0;
        Setmon();
        Console.WriteLine("\t\t Spaceinvador \n\t\t아무키나 누르세요");
        ConsoleKey a = Console.ReadKey().Key;
        Console.Clear();
        printMap();
        while (gameover==0) {

            if (Console.KeyAvailable)
            {
                a = Console.ReadKey().Key;
                player.Move(a);
                if (a == ConsoleKey.Spacebar)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (b[i] == null)
                        {
                            b[i] = new bullet(player.getX());
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 100; i++) {
                if (b[i] != null)
                {
                    for (int k = 0; k < 4; k++) {
                        for (int j = 0; j < 12; j++)
                        {
                            if (mon[k][j].Mondead() == false&& b[i].attack(mon[k][j]))
                            {
                                mon[k][j].Monattacked();
                                b[i] = null;
                                k = 4;
                                break;
                            }
                        }

                    }
                }
            }

            for (int i = 0; i < 100; i++)
            {
                if (b[i] != null)
                {
                    b[i].Move();
                    if (b[i].getY() == 0)
                        b[i] = null;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                        mon[i][j].Move();
                }
            }
            Thread.Sleep(100);
            Console.Clear();
            printMap();
            gameover = this.gameover();
        }
        if(gameover==-1)
            Console.WriteLine("\t\t you lose ");
        else
            Console.WriteLine("\t\t you win ");

    }





}

namespace space
{
    class Program
    {
        static void Main(string[] args)
        {
            Map m = new Map();
            m.play();
        }
    }
}
