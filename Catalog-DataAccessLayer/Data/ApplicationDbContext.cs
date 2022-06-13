using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=.;Database=PersonSurvey;Trusted_Connection=True",
                options => options.EnableRetryOnFailure());
            }
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }
        



    }
}
