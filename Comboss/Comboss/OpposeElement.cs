using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class OpposeElement
    {
        public static OpposeElement Instance { get; private set; } = new OpposeElement();
        Dictionary<Element, Element> oppose = new Dictionary<Element, Element>();

        public OpposeElement() {
            oppose.Add(Element.NEUTRAL, Element.NEUTRAL);

            //WATER > FIRE
            //FIRE > STONE
            //STONE > WIND
            //WIND > WATER
            oppose.Add(Element.WATER, Element.FIRE);
            oppose.Add(Element.FIRE, Element.STONE);
            oppose.Add(Element.STONE, Element.WIND);
            oppose.Add(Element.WIND, Element.WATER);
        }


        public bool IsOpposite(Element e1, Element e2)
        {
            Element tmpE = Element.NEUTRAL;
            if (oppose.TryGetValue(e1, out tmpE)){
                return (tmpE == e2);
            }
            else
             return false;
       }
   }
}
