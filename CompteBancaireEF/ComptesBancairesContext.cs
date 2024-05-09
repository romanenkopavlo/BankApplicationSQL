using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CompteBancaireEF;

public partial class ComptesBancairesContext : DbContext
{
    public string Fichier { get; private set; }
    public ComptesBancairesContext(string fichier) 
    {
        Fichier = fichier;
    }

    public ComptesBancairesContext(DbContextOptions<ComptesBancairesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compte> Comptes { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("data source=" + Fichier);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compte>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Proprietaire).HasColumnName("proprietaire");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdCompte).HasColumnName("idCompte");
            entity.Property(e => e.Montant)
                .HasColumnType("NUMERIC (8, 2)")
                .HasColumnName("montant");
            entity.Property(e => e.Notes).HasColumnName("notes");

            entity.HasOne(d => d.IdCompteNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.IdCompte)
                .OnDelete(DeleteBehavior.Restrict);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
