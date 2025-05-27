using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.models
{
    public class Entities
    {
        private string _name;
        private string _password;
        private string[] _tools = new string[5]{"Hammer","Chisel","Rope","Bag","Canteen"};
        private string _status;
        public Entities(string name , string password)
        {
            _name = name;
            _password = password;
        }

        public void Walk()
        {
            _status = "Walk";
            Console.WriteLine($"{_name} is {_status}ing");
        }

        public void Hide()
        {
            _status = "Hide";
            Console.WriteLine($"{_name} is {_status}ing");
        }

        public void Attack()
        {
            _status = "Attack";
            Console.WriteLine($"{_name} is {_status}ing");
        }
    }
}
