using System.Data.Entity;
using DevStore.Domain;
using DevStore.Infraestructure.Mappings;

namespace DevStore.Infraestructure.DataContexts
{

    public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() : base("DevStoreConnectionString")
        {
            Database.SetInitializer(new MySqlInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Configurations.Add(new ProductMap());
            //modelBuilder.Configurations.Add(new CategoryMap());
        }
    }


}
