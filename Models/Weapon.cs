using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherKendoEFDemo.Models
{
    public class Weapon
    {
        [Key]
        public int WeaponID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 15, ErrorMessage = "Attack Range must be between 0 - 15!")]
        [Display(Name = " Weapon Attack Power")]
        public int AttackPower { get; set; }

        public List<Character> Characters { get; set; }
    }
}
