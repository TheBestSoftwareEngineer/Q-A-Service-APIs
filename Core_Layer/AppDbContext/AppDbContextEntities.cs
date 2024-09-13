
using Core_Layer.Entities.Countries;
using Microsoft.EntityFrameworkCore;

namespace Core_Layer.AppDbContext
{
    public partial class AppDbContext
    {


        public DbSet<eCountryDA> Countries { get; set; }


      

    }
}
