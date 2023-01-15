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
        public int RetInt()
        {
            while (true)
            {
                Console.WriteLine("Ange längd i cm");
                if(int.TryParse(Console.ReadLine(), out int num))
                {
                    return num;
                    break;
                }
                else
                {
                    Console.WriteLine("Ange en siffra tack");
                }
            }
        }
        public virtual double Area { get; set; }
        [Key]
        public virtual int Id { get; set; }
    }
}
