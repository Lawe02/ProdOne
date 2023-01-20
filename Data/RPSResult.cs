using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class RPSResult
    {
        public char Result { get; set; }
        public double WinRate {get; set; }
        public string ComputerChoise { get; set; }  
        public string humanChoise { get; set; }
        public DateTime GameDate { get; set; }
    }
}
