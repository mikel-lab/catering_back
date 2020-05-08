using catering_back.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering_back.Servicios

    //Esta clase nos ayudará a crear las tablas en la BBDD mediante las entidades de los modelos
{
    public class CateringDbContext:DbContext
    {

        public CateringDbContext(DbContextOptions<CateringDbContext> options)
            :base(options)
        {
            Database.Migrate();

        }

        public virtual DbSet<Ingrediente> Ingredientes { get; set; }
        public virtual DbSet<Ingrediente_menu> Ingredientes_menus { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Tipo_menu> Tipos_menus { get; set; }


        //Establece relaciones entre entidades M-N
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingrediente_menu>()
                .HasKey(im => new { im.Id_menu, im.Id_ingrediente });
            modelBuilder.Entity<Ingrediente_menu>()
                .HasOne(i => i.Ingrediente)
                .WithMany(im => im.Ingredientes_Menus)
                .HasForeignKey(i => i.Id_ingrediente);
            modelBuilder.Entity<Ingrediente_menu>()
                .HasOne(m => m.Menu)
                .WithMany(im => im.Ingredientes_Menus)
                .HasForeignKey(m => m.Id_menu);

        }
    }
}
