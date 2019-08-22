namespace Aviacao
{
    using Aviacao;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelAviacao : DbContext
    {
        // Your context has been configured to use a 'ModelAviacao' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Aviao.ModelAviacao' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelAviacao' 
        // connection string in the application configuration file.
        public ModelAviacao()
            : base("name=ModelAviacao")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Passagem>().
                HasOptional<FormaDePagamento>(f=> f.Pagamento)
                .WithOptionalPrincipal<Passagem>(p => p.Passagem);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}