using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class AddElement : Boost
    {
        public override Element getElement()
        {
            return base.getElement() | elem;
        }

        public AddElement(I_Damage damage, Element element) : base(damage, element, 0)
        {

        }
    }
}
