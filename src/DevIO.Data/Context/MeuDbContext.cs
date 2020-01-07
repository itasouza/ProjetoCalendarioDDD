using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevIO.Data.Context
{
    public class MeuDbContext :DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // onde não tiver setado varchar e a propriedade for do tipo string fica valendo varchar(100)
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties()
               .Where(p => p.ClrType == typeof(string))))
                property.Relational().ColumnType = "varchar(100)";


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            //evitar a deleção em cascade
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(modelBuilder);
        }



    }
}
