using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherKendoEFDemo.Models
{
    public class Character
    {
        public int CharacterID { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Max Length for name is 25 characters. Choose a shorter name!")]
        public string Name { get; set; }

        [Required]
        [Display()]
        [Range(0, 15, ErrorMessage = "Attack Range must be between 0 - 15!")]
        public int AttackPower { get; set; }

        [Required]
        [Range(0, 15, ErrorMessage = "Defense Range must be between 0 - 15!")]
        public int DefensePower { get; set; }
        [Required]
        [ForeignKey("Weapon")]
        public int WeaponID { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
