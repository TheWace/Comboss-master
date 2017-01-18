using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class Boost : I_Damage
    {
        public I_Damage damage;
        public float amplitude;
        public Element elem;
        public virtual float getDamage()
        {
            return damage.getDamage();
        }

        public virtual Element getElement()
        {
            return damage.getElement();
        }

        public Boost (I_Damage d, Element e, float a)
        {
            damage = d;
            elem = e;
            amplitude = a;
        }
    }
}
