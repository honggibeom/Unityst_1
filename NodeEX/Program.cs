using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zone
{

    public string Name = "None";
    public List<Zone> LinkZone = new List<Zone>();
    public Zone Update()
    {
        while (true) {

            Console.Clear();

            Console.WriteLine("이곳은" + Name + "입니다");

            Console.WriteLine("이동할수 있는 장소 리스트");

            for (int i = 0; i < LinkZone.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + "." +LinkZone[i].Name);
            
            }

           
           int Number = (int)Console.ReadKey().Key;
            Number -= 49;
            return LinkZone[Number];
        }


    }
    public Zone(string _Name) {

        Name = _Name;
    }
}


namespace NodeEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Zone[] Newzone = new Zone[5];
            Newzone[0] = new Zone("태초마을");
            Newzone[1] = new Zone("초보사냥터");
            Newzone[2] = new Zone("중급사냥터");
            Newzone[3] = new Zone("중급마을");
            Newzone[4] = new Zone("고급사냥터");

            Newzone[0].LinkZone.Add(Newzone[1]);
            Newzone[0].LinkZone.Add(Newzone[2]);
            Newzone[1].LinkZone.Add(Newzone[3]);
            Newzone[2].LinkZone.Add(Newzone[3]);
            Newzone[3].LinkZone.Add(Newzone[4]);


            Zone startZone = Newzone[0];
            while (true) {

                startZone = startZone.Update();
            }
        }
    }
}
