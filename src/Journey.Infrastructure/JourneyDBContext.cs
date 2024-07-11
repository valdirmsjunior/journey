using System;
using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure
{
    public class JourneyDBContext : DbContext
    {
        public DbSet<Trip> Trips { get;  set; }
        //para usar no sqlite temos q adicionar isso para seguir o exemplo 
        //se tiver usando o sqlserver nao haveria necessidade de adicionar para esse exemplo
        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/Users/valdirmsjunior/www/SQLite/JourneyDatabase.db");
        }

        //**Devido ao erro do sqlite esse método deve ser apagdo e a 
        //deve ser adicionado la em cima public DbSet<Activity> Activities { get; set; }*/
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Activity>().ToTable("Activities");
        // }
    }
}