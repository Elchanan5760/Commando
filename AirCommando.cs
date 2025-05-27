using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos.models
{
    public class AirCommando : Commando
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
        public AirCommando(string name, string codeName) : base(name, codeName)
        {
            _name = name;
            _codeName = codeName;
        }
        public override void Attack(Enemy enemy)
        {
            _status = "attack";
            Console.WriteLine($"Air commando named {_name} code name {_codeName} is {_status}ing {enemy.GetName()}");
        }
        public string Skydiving()
        {
            _status = "skydive";
            Console.WriteLine($"{_name} is {_status.Substring(0, _status.Length - 1)}ing");
            return $"{_name} is {_status.Substring(0, _status.Length - 1)}ing";
        }
    }
}
