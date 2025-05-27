
using commandos.models;
namespace CommandoPrject
{
    class Program
    {
        static void Main()
        {
            SeaCommando o1 = new SeaCommando("Elchanan", "6rf55");
            o1.Attack();
            o1.Hide();
            o1.Walk();
            o1.Swimming();
            o1.SayName("colonel");
            AirCommando o2 = new AirCommando("Elchanan", "6rf55");
            o2.Attack();
            o2.Hide();
            o2.Walk();
            o2.Skydiving();
            Commando o3 = new Commando("Elchanan", "6rf55");
            o3.Attack();
            o3.Hide();
            o3.Walk();
            List<Commando> soldiers = new List<Commando> { o1, o2, o3 };
            
            foreach (Commando s in soldiers)
            {
                s.Attack();
            }
        //    Weapon s1 = new Weapon("gd", "tydf", 10);
        //    s1.Shoot();
        //    s1.Shoot();
        //    Console.WriteLine(o1.CodeName);
        //    o1.CodeName = "fve67";
        //    Console.WriteLine(o1.CodeName);
        }
    }
}