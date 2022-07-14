namespace DataVoiture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("VoitureVente")]
    public partial class VoitureVente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoitureVente()
        {
            FactureAchats = new HashSet<FactureAchat>();
            FactureVentes = new HashSet<FactureVente>();
        }

        //annotation de données pour désigner la clé primaire

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_voiture { get; set; }

        [Required]
        [StringLength(50)]
        public string Marque { get; set; }

        [Required]
        [StringLength(50)]
        public string Modele { get; set; }

        [Required]
        [StringLength(4)]
        public string Annee { get; set; }

        public int? Chevaux_vapeur { get; set; }

        [StringLength(50)]
        public string Couleur { get; set; }

        [StringLength(50)]
        public string NIV { get; set; }

        public int? Numero_portes { get; set; }

        public bool? Sieges_en_cuir { get; set; }

        public bool? Demarrage_a_distance { get; set; }

        public bool? Toit_ouvrant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactureAchat> FactureAchats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactureVente> FactureVentes { get; set; }
    }
}
