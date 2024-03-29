namespace DataVoiture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactureVente")]
    public partial class FactureVente
    {

        //annotation de donn�es pour d�signer la cl� primaire

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        //d�finir des contraintes non annulables et uniques
        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string NumFacture { get; set; }
        
        [Required]
        public int Id_voiture { get; set; }

        public int? Id_client { get; set; }

        [Required]
        public decimal Prix { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        //d�finir une cl� �trang�re sur les propri�t�s de navigation
        [ForeignKey("Id_client")]
        public virtual Client Client { get; set; }

        [ForeignKey("Id_voiture")]
        public virtual VoitureVente VoitureVente { get; set; }
    }
}
