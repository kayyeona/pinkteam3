using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISCAP.Models
{
    public class Workshop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public string workShoptitle { get; set; }
        [Required]
        public string workShopname { get; set; }
        [Required]
        public string workShopAffiliation { get; set; }
        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        [MaxLength(300)]
        public string workShopOverview { get; set; }
        [Required]
        [MaxLength(50)]
        public string targAud { get; set; }
        [Required]
        public string timeRequested { get; set; }

        [Required]
        public string workShopEquipmentSetupPart { get; set; }
    }
}