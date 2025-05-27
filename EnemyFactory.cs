using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class EnemyFactory
    {
        private string _name;
        private int _life;
        private string _lifeStatus;
        public EnemyFactory(string name , int life , string lifeStatus)
        {
            _name = name;
            _life = life;
            _lifeStatus = lifeStatus;
        }
        public void Yelling()
        {
            Console.WriteLine("I am an enemy");
        }
    }
}
