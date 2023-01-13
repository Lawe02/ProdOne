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
            var menu = new Menu();
            var dt = new DataInitializer();
            var ShapeService = new ShapeService();

            using(var db = bas.BuildApp())
            {
                db.Database.Migrate();
                dt.AddShapes(db);
                db.SaveChanges();
                while (true)
                {
                    var s = new Shape();
                    var sel = menu.ShapeMenu();
                    switch (sel)
                    {
                        case 1:
                            s = ShapeService.AddShape(1);
                            db.Shapes.Add(s);
                            db.SaveChanges();
                            break;

                        case 2:
                            s = ShapeService.AddShape(2);
                            db.Shapes.Add(s);
                            db.SaveChanges();
                            break;

                        case 3:
                            s = ShapeService.AddShape(3);
                            db.Shapes.Add(s);
                            db.SaveChanges();
                            break;

                        case 4:
                            s = ShapeService.AddShape(4);
                            db.Shapes.Add(s);
                            db.SaveChanges();
                            break;
                    }
                    
                }
            }
        }
    }
}
