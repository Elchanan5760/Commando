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
        private string _codeName;
        private string[] _tools = new string[5]{"Hammer","Chisel","Rope","Bag","Watery"};
        private string _status;
        public Entities(string name , string codeName)
        {
            _name = name;
            _codeName = codeName;
        }

        public void Walk()
        {
            _status = "walk";
            Console.WriteLine($"{_name} is {_status}ing");
        }

        public void Hide()
        {
            _status = "hide";
            Console.WriteLine($"{_name} is {_status}ing");
        }

        public void Attack()
        {
            _status = "attack";
            Console.WriteLine($"{_name} code name {_codeName} is {_status}ing");
        }
    }
}
