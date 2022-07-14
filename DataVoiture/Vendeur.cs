namespace DataVoiture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.Design;
    using System.Data.Entity.Spatial;
    using System.Drawing;
    using System.Text.RegularExpressions;

    [Table("Vendeur")]
    public partial class Vendeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        private string telephone;
        private Regex regTelephone = new Regex(@"^\(?\d{3}\)?[\s-]\d{3}[\s-]\d{4}$");


        public Vendeur()
        {
            //un vendeur peut avoir une collection de factures qui lui sont attribuées

            FactureAchats = new HashSet<FactureAchat>();
        }

        //annotation de données pour désigner la clé primaire

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //annotation de données pour indiquer les champs non-nullables
        [Required]
        [StringLength(50)]
        public string Nom { get; set; }

        //Propriété permettant de définir le format du téléphone qui respecte la regex définie précédemment
        [StringLength(50)]
        public string Telephone
        {
            get => telephone;
            set
            {
                if (this.regTelephone.IsMatch(value))
                    telephone = value;
                else
                    throw new Exception("Le telephone doit etre sous les formes (CCC) CCC-CCCC,CCC CCC-CCCC, CCC-CCC CCCC ou CCC-CCC-CCCC.");
            }
        }

        [StringLength(50)]
        public string Email
        {
            get; set;
        }

        [StringLength(50)]
        public string Adresse { get; set; }

        [StringLength(50)]
        public string Ville { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactureAchat> FactureAchats { get; set; }
    }
}
