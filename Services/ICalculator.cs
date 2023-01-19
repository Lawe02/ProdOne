using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;

namespace ProjectOne.Services
{
    public interface ICalculator
    {
        CalculationResult RetCalculation(int a, int b, string operatore); 
    }
}
