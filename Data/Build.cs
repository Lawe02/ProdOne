using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjectOne.Data
{
    public class Build
    {
        public ApplicationDbContext BuildApp()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionsString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionsString);
            var a = new ApplicationDbContext(options.Options);
            return a;
        }
    }
}
