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
        private readonly Library _library;
        private readonly RPSServices _rpsService;
        private readonly CalculatorServices _calculatorServices;
        private readonly Shape _shape;
        private readonly ApplicationDbContext _context;
        private readonly shapeService _shapeService;
        private readonly ICalculator[] _calculators = {new Addition(), new Subtraktion(), new Division(), new Multiplikation(), new Sqrt(), new Modulus() };
        public Menu(ApplicationDbContext dbContext, shapeService service, RPSServices rpsService, CalculatorServices calculatorServices, Shape shape, Library library)
        {
            _context = dbContext;
            _shapeService = service;
            _rpsService = rpsService;
            _calculatorServices = calculatorServices;
            _shape = shape;
            _library = library; 
        }
        public void ShapeMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                var options = new string[] {
                                            "Ange 1 för Romb",
                                            "Ange 2 för Rektangel",
                                            "Ange 3 för Paralellogram",
                                            "Ange 4 för Triangel",
                                            "Ange 5 för att gå tillbaka",
                                            "Ange 6 för att ta bort shape",
                                            "Ange 7 för att uppdatera shape",
                                            "Ange 8 för att se alla shapes"
                                            };
                var val = _library.MenuHandler(options);

                try
                {
                    switch (val)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void CalcMenu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.Clear();
                //Console.WriteLine("Ange 1 för addition");
                //Console.WriteLine("Ange 2 för subtraktion");
                //Console.WriteLine("Ange 3 för division");
                //Console.WriteLine("Ange 4 för multiplikation");
                //Console.WriteLine("Ange 5 för roten");
                //Console.WriteLine("Ange 6 för modulus");
                //Console.WriteLine("Ange 7 för att updatera beräkning");
                //Console.WriteLine("Ange 8 för att se alla beräkningar");
                //Console.WriteLine("Ange 9 för att ta bort beräkning");
                //Console.WriteLine("Ange 10 för att gå tillbaka");

                var options = new string[] {
                                            "Ange 1 för addition",
                                            "Ange 2 för subtraktion",
                                            "Ange 3 division", 
                                            "Ange 4 för multiplikation",
                                            "Ange 5 för roten",
                                            "Ange 6 för modulus", 
                                            "Ange 7 för att uppdatera beräkning",
                                            "Ange 8 för att se alla beräkningar",
                                            "Ange 9 för att ta bort beräkning",
                                            "Ange 10 för att gå tillbaka"
                                            };

                var val = _library.MenuHandler(options);
                try
                {
                    switch (val)
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
                            _calculatorServices.ShowCalcs(_context);
                            var calcToUpdate = _calculatorServices.GetCalc(_context);
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
                            _calculatorServices.ShowCalcs(_context);
                            break;
                        case 9:
                            _calculatorServices.ShowCalcs(_context);
                            var calcToDelete = _calculatorServices.GetCalc(_context);
                            _context.CalculationResults.Remove(calcToDelete);
                            _context.SaveChanges();
                            break;

                        case 10:
                            MainMenu();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void RPSMenu()
        {
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Ange 1 för att spela mot datorn");
                //Console.WriteLine("Ange 2 för att se nuvarande vinstsnitt");
                //Console.WriteLine("c");
                Console.ForegroundColor = ConsoleColor.Gray;
                var options = new string[] { 
                                            "Ange 1 för att spela mot datorn",
                                            "Ange 2 för att se nuvarande vinstsnitt",
                                            "Ange 2 för att se nuvarande vinstsnitt"
                                            };

                var option = _library.MenuHandler(options);

                try
                {
                    switch (option)
                    {
                        case 1:
                            var game = _rpsService.Game(_context);
                            _context.Results.Add(game);
                            _context.SaveChanges();
                            break;

                        case 2:
                            _rpsService.ShowRate(_context);
                            break;

                        case 3:
                            MainMenu();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
        public void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                var options = new string[] {
                                            "Ange 1 för att komma till shapeMenu", 
                                            "Ange 2 för att komma till kalkylatorMenu",
                                            "Ange 3 för att komma till StenSaxPåsemMenu"
                                            };

                var option = _library.MenuHandler(options);

                try
                {
                    switch (option)
                    {
                        case 1:
                            ShapeMenu();
                            break;

                        case 2:
                            CalcMenu();
                            break;

                        case 3:
                            RPSMenu();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
