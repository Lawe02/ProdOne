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
        public virtual string Form { get; set; }
        public virtual double Circumference { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual void GetParams()
        {

        }
        public virtual double Area { get; set; }
        [Key]
        public virtual int Id { get; set; }
    }
}
