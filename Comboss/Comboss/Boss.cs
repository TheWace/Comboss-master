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
        public Element element;
        private int level; 

        public Boss(float vie, string nom, Element e, int niv)
        {
            life = vie;
            name = nom;
            element = e;
            level = niv;
        }

        public Boolean Attaque(I_Damage damage, Element currentelem) {
            if (life == 0 && element == oppose(currentelem)) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
