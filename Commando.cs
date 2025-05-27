using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.models
{
    public abstract class Commando
    {
        private string _name;
        private string _codeName { get; set; }
        public string CodeName
        {
            get { return _codeName; }
            set { _codeName = value; }
        }
        private string[] _tools = new string[5]{"Hammer","Chisel","Rope","Bag","Watery"};
        private string _status;
        public Commando(string name , string codeName)
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
        public string SayName(string commanderRank)
        {
            switch (commanderRank.ToLower())
            {
                case "general":
                    Console.WriteLine($"The name is {_name}");
                    return _name;
                case "colonel":
                    Console.WriteLine($"The code name is {_codeName}");
                    return _name;
                default:
                    Console.WriteLine("This information is unathotized");
                    return "This information is unathotized";
            }
        }
    }
}
