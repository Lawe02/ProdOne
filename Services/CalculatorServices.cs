using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;

namespace ProjectOne.Services
{
    public class CalculatorServices 
    {
        public void ShowCalcs(ApplicationDbContext db)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("---ALLA BERÄKNIGAR---");
            db.CalculationResults.ToList().ForEach(x => Console.WriteLine($"ID: {x.Id} || CREATEDATE: {x.CreateDate} || A: {x.A} || B: {x.B} || SUM: {x.Sum} || OPERATOR: {x.Operatore}"));
            Console.WriteLine("Tryck enter för att gå vidare");
            Console.ReadLine();
        }
        public CalculationResult GetCalc(ApplicationDbContext db)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ange Id");
                if(int.TryParse(Console.ReadLine(), out int id))
                {
                    var res = db.CalculationResults.FirstOrDefault(x => x.Id == id);
                    if (res == null)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Ange ett Id somexisterar");
                    }
                    else
                    {
                        return res;
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ange ett tal");
                }
            }
            
        }
    }
    public class Addition : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a + b, operatore, DateTime.Now);
            return result;
        }
    }

    public class Subtraktion : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a - b, operatore, DateTime.Now);
            return result;
        }
    }

    public class Division : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a / b, operatore, DateTime.Now);
            return result;
        }
    }

    public class Multiplikation : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a * b, operatore, DateTime.Now);
            return result;
        }
    }
    public class Sqrt : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, Math.Sqrt(a), operatore, DateTime.Now);
            return result;
        }
    }

    public class Modulus : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a % b, operatore, DateTime.Now);
            return result;
        }
    }
} 
