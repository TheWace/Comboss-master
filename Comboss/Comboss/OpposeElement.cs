using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class OpposeElement
    {
        OpposeElement oE = new OpposeElement();
        Dictionary<Element, Element> oppose = new Dictionary<Element, Element>();

        public void init() {
            oppose.Add(Element.NEUTRAL, Element.NEUTRAL);
            oppose.Add(Element.FIRE, Element.WATER);
            oppose.Add(Element.WATER, Element.FIRE);
            oppose.Add(Element.STONE, Element.WIND);
            oppose.Add(Element.WIND, Element.STONE);
        }


        public bool IsOpposite(Element e1, Element e2)
        {
            Element tmpE;
            if (oppose.TryGetValue(e1, out tmpE)){
                return (tmpE == e2);
            }
            else
             return false;
       }
   }
}
