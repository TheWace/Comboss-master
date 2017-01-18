using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class Attaque : I_Damage
    {

        public float getDamage()
        {
            return 10;
        }

        public Element getElement()
        {
            return Element.NEUTRAL;
        }
    }
}
