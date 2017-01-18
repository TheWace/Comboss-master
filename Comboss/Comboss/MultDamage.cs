using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class MultDamage : Boost
    {
        public override float getDamage()
        {
            return base.getDamage() * amplitude;
        }
        public MultDamage(I_Damage damage, float amplitude) : base(damage, Element.NEUTRAL, amplitude)
        {

        }
    }
}
