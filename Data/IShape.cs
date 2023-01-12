using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Data
{
    public class Shape
    {
        public string Form { get; set; }
        public double Circumference { get; set; }
        public DateTime CreateDate { get; set; }
        public void GetParams()
        {

        }
        public double Area { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
