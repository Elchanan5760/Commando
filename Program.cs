
using commandos.models;
namespace Commando
{
    class Program
    {
        static void Main()
        {
            Entities o1 = new Entities("Elchanan","6rf55");
            o1.Attack();
            o1.Hide();
            o1.Walk();
            o1.SayName("colonel");
            Weapon s1 = new Weapon("gd", "tydf", 10);
            s1.Shoot();
            s1.Shoot();
            Console.WriteLine(o1.CodeName);
            o1.CodeName = "fve67";
            Console.WriteLine(o1.CodeName);
        }
    }
}