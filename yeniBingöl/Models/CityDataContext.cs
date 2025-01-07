using System.Data.Entity;

namespace yeniBingöl.Models
{
    public class CityDataContext : DbContext
    {
        public DbSet<Ilceler> Ilceler { get; set; }
        public DbSet<NufusBilgi> NufusBilgi { get; set; }

        public CityDataContext() : base("CityDataConnection")
        {
        }
    }
}
