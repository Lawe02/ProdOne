using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectOne.Data;
using ProjectOne.Services;

namespace ProjectOne.Services
{
    public class Menu
    {
        private readonly CalculatorServices _calcServices = new CalculatorServices();
        private readonly Shape _shape = new Shape();
        private readonly ApplicationDbContext _context;
        private readonly shapeService _shapeService;
        private readonly ICalculator[] _calculators = {new Addition(), new Subtraktion(), new Division(), new Multiplikation(), new Sqrt(), new Modulus() };
        public Menu(ApplicationDbContext dbContext, shapeService service)
        {
            _context = dbContext;
            _shapeService = service;
        }
        public void ShapeMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ange 1 för Romb");
                Console.WriteLine("Ange 2 för Rektangel");
                Console.WriteLine("Ange 3 för Paralellogram");
                Console.WriteLine("Ange 4 för Triangel");
                Console.WriteLine("Ange 5 för att gå tillbaka");
                Console.WriteLine("Ange 6 för att ta bort shape");
                Console.WriteLine("Ange 7 för att uppdatera shape");
                Console.WriteLine("Ange 8 för att se alla former");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            var s = _shapeService.AddShape(1);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 2:
                            s = _shapeService.AddShape(2);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 3:
                            s = _shapeService.AddShape(3);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 4:
                            s = _shapeService.AddShape(4);
                            _context.Shapes.Add(s);
                            _context.SaveChanges();
                            break;

                        case 5:
                            MainMenu();
                            break;

                        case 6:
                            _shapeService.ReadShapes(_context);
                            var shapeToRemove = _shapeService.ReturnShape(_context);
                            _context.Shapes.Remove(shapeToRemove);
                            _context.SaveChanges();
                            break;
                        
                        case 7:
                            _shapeService.ReadShapes(_context);
                            var shapeToUpdate = _shapeService.ReturnShape(_context);
                            shapeToUpdate = _shapeService.UpdateShape(shapeToUpdate);
                            _context.SaveChanges();
                            break;

                        case 8:
                            _shapeService.ReadShapes(_context);
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void CalcMenu()
        {
            while (true)
            {
                Console.WriteLine("Ange 1 för addition");
                Console.WriteLine("Ange 2 för subtraktion");
                Console.WriteLine("Ange 3 för division");
                Console.WriteLine("Ange 4 för multiplikation");
                Console.WriteLine("Ange 5 för roten");
                Console.WriteLine("Ange 6 för modulus");
                Console.WriteLine("Ange 7 för att updatera beräkning");
                Console.WriteLine("Ange 8 för att se alla beräkningar");
                Console.WriteLine("Ange 9 för att ta bort beräkning");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            int a = _shape.RetInt("Ange faktor a");
                            int b = _shape.RetInt("Ange faktor b");
                            var result = _calculators[1 - 1].RetCalculation(a, b, "Addition");
                            _context.CalculationResults.Add(result);
                            _context.SaveChanges();
                            break;

                        case 2:
                            int suba = _shape.RetInt("Ange faktor a");
                            int subb = _shape.RetInt("Ange faktor b");
                            var result2 = _calculators[2 - 1].RetCalculation(suba, subb, "Subtraktion");
                            _context.CalculationResults.Add(result2);
                            _context.SaveChanges();
                            break;

                        case 3:
                            int div1 = _shape.RetInt("Ange täljare");
                            int div2 = _shape.RetInt("Ange nämnare");
                            var divres = _calculators[3 - 1].RetCalculation(div1, div2, "Division");
                            _context.CalculationResults.Add(divres);
                            _context.SaveChanges();
                            break;

                        case 4:
                            int mult1 = _shape.RetInt("Ange faktor a");
                            int mult2 = _shape.RetInt("Ange faktor b");
                            var multres = _calculators[4 - 1].RetCalculation(mult1, mult2, "Multiplikation");
                            _context.CalculationResults.Add(multres);
                            _context.SaveChanges();
                            break;

                        case 5:
                            int sqrt = _shape.RetInt("Ange faktorn");
                            var sqrtres = _calculators[5 - 1].RetCalculation(sqrt, 0, "Sqrt");
                            _context.CalculationResults.Add(sqrtres);
                            _context.SaveChanges();
                            break;

                        case 6:
                            int tälj = _shape.RetInt("Ange täljare");
                            int nmn = _shape.RetInt("Ange nämnare");
                            var modres = _calculators[6 - 1].RetCalculation(tälj, nmn, "Modulus");
                            _context.CalculationResults.Add(modres);
                            _context.SaveChanges();
                            break;

                        case 7:
                            _calcServices.ShowCalcs(_context);
                            var calcToUpdate = _calcServices.GetCalc(_context);
                            int aToUpdate = _shape.RetInt("Ange faktor A");
                            int bToUpdate;

                            if (calcToUpdate.Operatore != "Sqrt")
                                bToUpdate = _shape.RetInt("Ange faktor B");
                            else
                                bToUpdate = 0;
                            
                            var newPropCalc = _calculators.ToList().First(x => x.GetType().Name == calcToUpdate.Operatore).RetCalculation(aToUpdate, bToUpdate, calcToUpdate.Operatore);
                            calcToUpdate.A = aToUpdate;
                            calcToUpdate.B = bToUpdate;
                            calcToUpdate.Sum = newPropCalc.Sum;
                            _context.SaveChanges();
                            break;
                        case 8:
                            _calcServices.ShowCalcs(_context);
                            break;
                        case 9:
                            _calcServices.ShowCalcs(_context);
                            var calcToDelete = _calcServices.GetCalc(_context);
                            _context.CalculationResults.Remove(calcToDelete);
                            _context.SaveChanges();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Ange 1 för att komma till shapeMenu");
                Console.WriteLine("Ange 2 för att komma till kalkylatorMenu");
                Console.WriteLine("Ange 3 för att komma till StenSaxPåseMenu");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            ShapeMenu();
                            break;

                        case 2:
                            CalcMenu();
                            break;

                        case 3:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
