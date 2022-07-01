using System;
using System.Data.Entity;
using System.Linq;

namespace EntityCodeFirst
{
    public class QLSV : DbContext
    {
        // Your context has been configured to use a 'QLSV' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityCodeFirst.QLSV' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLSV' 
        // connection string in the application configuration file.
        public QLSV()
            : base("name=QLSV")
        {
            Database.SetInitializer<QLSV>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<LopSH> LopSHes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}