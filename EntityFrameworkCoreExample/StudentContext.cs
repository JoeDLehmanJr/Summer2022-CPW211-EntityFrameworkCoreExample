using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    // EF Core getting started
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. localdb is included
            //  with Visual Studio
            //
            // Trusted_Connection = indicates that our windows account should be used
            // Remember putting an asterix in front of the string allows you to
            // not have to escape the special characters like \
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

    }

}
