using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectOne.Data;

namespace ProjectOne
{
    public class Application
    {
        public void Run()
        {
            var bas = new Build();
            using(var db = bas.BuildApp())
            {
                db.Database.Migrate();
            }
        }
    }
}
