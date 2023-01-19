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
                var dt = new DataInitializer(db);
                var ShapeService = new shapeService();
                var menu = new Menu(db, ShapeService);

                db.Database.Migrate();
                dt.AddShapes();
                db.SaveChanges();
                menu.MainMenu();

            }
        }
    }
}
