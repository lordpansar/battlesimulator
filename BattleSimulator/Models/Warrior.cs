using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimulator.Models
{
    public class Warrior
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Iniative { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }
        public int MinDefense { get; set; }
        public int MaxDefense { get; set; }
        public bool IsAlive { get; set; }
    }
}