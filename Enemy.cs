using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    public class Enemy
    {
        private string _name;
        private int _life = 100;
        private string _lifeStatus;
        public Enemy(string name , string lifeStatus)
        {
            _name = name;
            _lifeStatus = lifeStatus;
        }
        public string GetName()
        {
            return _name;
        }
        public int ReducesLife()
        {
            _life -= 1;
            return _life;
        }
        public string IsAlive()
        {
            return _name;
        }
        public void Yelling()
        {
            Console.WriteLine("I am an enemy");
        }
    }
}
