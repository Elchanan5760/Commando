using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.models
{
    public class Weapon
    {
        private string _name;
        private string _manufacturer;
        private int _bulletSapply;
        public Weapon(string name,string manufacturer,int bulletSapply)
        {
            _name = name;
            _manufacturer = manufacturer;
            _bulletSapply = bulletSapply;
        }

        public void Shoot()
        {
            _bulletSapply -= 1;
            Console.WriteLine("Shooting...\n" +
                $"{_bulletSapply} bullet left"); 
        }
    }
}
