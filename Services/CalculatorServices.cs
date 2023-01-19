using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;

namespace ProjectOne.Services
{
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

    public class Modululs : ICalculator
    {
        public CalculationResult RetCalculation(int a, int b, string operatore)
        {
            var result = new CalculationResult(a, b, a % b, operatore, DateTime.Now);
            return result;
        }
    }
}
