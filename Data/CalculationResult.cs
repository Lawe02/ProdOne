using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class CalculationResult
    {
        [Key]
        public int Id { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public double Sum { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operatore { get; set; }

        public CalculationResult(int a, int b, double sum, string operatore, DateTime createDate)
        {
            A = a;
            B = b;
            Sum = sum;
            CreateDate = createDate;
            Operatore = operatore;
        }
    }
}
