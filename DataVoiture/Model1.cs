using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataVoiture
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=VoitureContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<FactureAchat> FactureAchats { get; set; }
        public virtual DbSet<FactureVente> FactureVentes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Vendeur> Vendeurs { get; set; }
        public virtual DbSet<VoitureVente> VoitureVentes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Ville)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.CodePostal)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.FactureVentes)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.Id_client);

            modelBuilder.Entity<FactureAchat>()
                .Property(e => e.NumFacture)
                .IsUnicode(false);

            modelBuilder.Entity<FactureAchat>()
                .Property(e => e.Prix)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FactureVente>()
                .Property(e => e.NumFacture)
                .IsUnicode(false);

            modelBuilder.Entity<FactureVente>()
                .Property(e => e.Prix)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Ville)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Vendeur>()
                .HasMany(e => e.FactureAchats)
                .WithOptional(e => e.Vendeur)
                .HasForeignKey(e => e.Id_vendeur);

            modelBuilder.Entity<VoitureVente>()
                .Property(e => e.Marque)
                .IsUnicode(false);

            modelBuilder.Entity<VoitureVente>()
                .Property(e => e.Modele)
                .IsUnicode(false);

            modelBuilder.Entity<VoitureVente>()
                .Property(e => e.Annee)
                .IsUnicode(false);

            modelBuilder.Entity<VoitureVente>()
                .Property(e => e.Couleur)
                .IsUnicode(false);

            modelBuilder.Entity<VoitureVente>()
                .Property(e => e.NIV)
                .IsUnicode(false);
        }
    }
}
