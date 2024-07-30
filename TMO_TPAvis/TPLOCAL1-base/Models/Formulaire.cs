using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Formulaire
    {
        [Required(ErrorMessage = "Le champ Nom est requis.")]
        [Display(Name = "Nom")]
        public string Nom        { get; set; }
        [Required]
        [Display(Name = "Prenom")]
        public string Prenom     { get; set; }
        [Required]
        [Display(Name = "Sexe")]
        public string Sexe       { get; set; }
        [Required]
        [Display(Name = "Adresse")]
        public string Adresse    { get; set; }
        [Required]
        [Display(Name = "Code")]
        public int    Code       { get; set; }
        [Required]
        [Display(Name = "Ville")]
        public string Ville      { get; set; }
        [Required]
        [Display(Name = "Mail")]
        public string Mail       { get; set; }
        [Required]
        [Display(Name = "DateDebut")]
        public string DateDebut  { get; set; }
        [Required]
        [Display(Name = "Formation")]
        public string Formation  { get; set; }
        [Required]
        [Display(Name = "AvisCOBOL")]
        public string AvisCOBOL  { get; set; }
        [Required]
        [Display(Name = "AvisC#")]
        public string AvisCSharp { get; set; }
    }
}
