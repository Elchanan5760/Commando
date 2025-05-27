using commandos.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.models
{
    public class SeaCommando : Commando
    {
        private string _name;
        private string _codeName { get; set; }
        public string CodeName
        {
            get { return _codeName; }
            set { _codeName = value; }
        }
        private string[] _tools = new string[5] { "Hammer", "Chisel", "Rope", "Bag", "Watery" };
        private string _status;
        public SeaCommando(string name, string codeName):base(name,codeName)
        {
            _name = name;
            _codeName = codeName;
        }
        public override void Attack(Enemy enemy)
        {
            _status = "attack";
            Console.WriteLine($"Sea commando named {_name} code name {_codeName} is {_status}ing {enemy.GetName()}");
        }
        public string Swimming()
        {
            _status = "swim";
            Console.WriteLine($"{_name} is {_status}ming");
            return $"{_name} is {_status}ming";
        }
    }
}
