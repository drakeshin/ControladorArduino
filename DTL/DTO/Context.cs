using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTL.DTO
{
    public class Context : DbContext
    {
        public DbSet<PARAMETRO> PARAMETRO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<ARDUINO> ARDUINO { get; set; }
        public DbSet<COMPONENTE> COMPONENTE { get; set; }
        public DbSet<TIPO_COMPONENTE> TIPO_COMPONENTE { get; set; }
        public DbSet<ARDUINO_COMPONENTE> ARDUINO_COMPONENTE { get; set; }
        public DbSet<ACAO> ACAO { get; set; }
        public DbSet<ACAO_COMPONENTE> ACAO_COMPONENTE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=InternalStorage.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PARAMETRO>()
                .HasKey(parametro => parametro.IdParametro);
            modelBuilder.Entity<PARAMETRO>()
                .Property(parametro => parametro.IdParametro).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<USUARIO>()
                .HasKey(usuario => usuario.IdUsuario);
            modelBuilder.Entity<USUARIO>()
                .Property(usuario => usuario.IdUsuario).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ARDUINO>()
               .HasKey(arduino => arduino.IdArduino);
            modelBuilder.Entity<ARDUINO>()
                .Property(arduino => arduino.IdArduino).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<COMPONENTE>()
               .HasKey(componente => componente.IdComponente);
            modelBuilder.Entity<COMPONENTE>()
                .Property(componente => componente.IdComponente).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<TIPO_COMPONENTE>()
               .HasKey(tipoComponente => tipoComponente.IdTipoComponente);
            modelBuilder.Entity<TIPO_COMPONENTE>()
                .Property(tipoComponente => tipoComponente.IdTipoComponente).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ARDUINO_COMPONENTE>()
              .HasKey(arduinoComponente => arduinoComponente.IdArduinoComponente);
            modelBuilder.Entity<ARDUINO_COMPONENTE>()
                .Property(arduinoComponente => arduinoComponente.IdArduinoComponente).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ACAO>()
              .HasKey(acao => acao.IdAcao);
            modelBuilder.Entity<ACAO>()
                .Property(acao => acao.IdAcao).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ACAO_COMPONENTE>()
             .HasKey(acaoComponente => acaoComponente.IdAcaoComponente);
            modelBuilder.Entity<ACAO_COMPONENTE>()
                .Property(acaoComponente => acaoComponente.IdAcaoComponente).ValueGeneratedOnAddOrUpdate();
        }
    }
}
