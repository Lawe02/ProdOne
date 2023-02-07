using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectOne.Data;
using ProjectOne.Services;

namespace ProjectOne
{
    public class Application
    {
        public void Run()
        {
            var bas = new Build();

            using(var db = bas.BuildApp())
            {
                var library = new Library();
                var shape = new Shape();
                var dt = new DataInitializer(db);
                var calc = new CalculatorServices();
                var ShapeService = new shapeService();
                var rps = new RPSServices();
                var menu = new Menu(db, ShapeService, rps, calc, shape, library);

                db.Database.Migrate();
                dt.AddShapes();
                db.SaveChanges();
                menu.MainMenu();

            }
        }
    }
}
