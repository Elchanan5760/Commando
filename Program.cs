
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
            Weapon s1 = new Weapon("gd", "tydf", 10);
            s1.Shoot();
            s1.Shoot();
        }
    }
}