using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class Boss
    {
        private float life;
        private string name;
        private Element element;
        private int level; 

        public Boss(float vie, string nom, Element e, int niv)
        {
            life = vie;
            name = nom;
            element = e;
            level = niv;
        }
    }
}
