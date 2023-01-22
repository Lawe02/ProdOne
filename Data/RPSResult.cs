using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class RPSResult
    {
        [Key]
        public int Id { get; set; }
        public char Result { get; set; }
        public double WinRate { get; set; }
        public string ComputerChoise { get; set; }  
        public string HumanChoise { get; set; }
        public DateTime GameDate { get; set; }

        public RPSResult(char result, DateTime gameDate, string computerChoise, string humanChoise, double winRate)
        {
            Result = result;
            GameDate = gameDate;
            ComputerChoise = computerChoise;
            HumanChoise = humanChoise;
            WinRate = winRate;
        }
    }
}
