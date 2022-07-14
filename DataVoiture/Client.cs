namespace DataVoiture
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Text.RegularExpressions;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            FactureVentes = new HashSet<FactureVente>();
        }
        private string nom;
        private string prenom;
        private string telephone;

        private Regex regNom = new Regex(@"^[\p{L}-]+$");
        private Regex regTelephone = new Regex(@"^\(?\d{3}\)?[\s-]\d{3}[\s-]\d{4}$");


        //annotation de données pour désigner la clé primaire

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        //indiquent les propriétés nom, prénom et téléphone qui doivent respecter la regex correspondante
        public string Nom
        {
            get => nom;
            set
            {
                if (this.regNom.IsMatch(value))
                    nom = value;
                else
                    throw new Exception("Le nom doit etre composé que des lettres");
            }
        }

        //annotation de données pour désigner le champ non-nullable

        [Required]
        [StringLength(50)]
        public string Prenom
        {
            get => prenom;
            set
            {
                if (this.regNom.IsMatch(value))
                    prenom = value;
                else
                    throw new Exception("Le prenom doit etre composé que des lettres");
            }
        }

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
            get;set;
        }

        [StringLength(50)]
        public string Adresse { get; set; }

        [StringLength(50)]
        public string Ville { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string CodePostal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactureVente> FactureVentes { get; set; }
    }
}
