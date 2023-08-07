using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }   
        public string MachineType { get; set; }
        public string MachineDescription { get; set; }
        public Engineer Engineer { get; set; }
        

    }
}