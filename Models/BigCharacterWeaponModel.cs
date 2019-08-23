using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherKendoEFDemo.Models
{
    public class BigCharacterWeaponModel
    {
        public IEnumerable<Character> Characters { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }
    }
}
