using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comboss
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss B1 = new Boss(10, "Gobi le roi Glob", Element.NEUTRAL, 1);
            Boss B2 = new Boss(20, "Pimienta le seigneur Sing-Piment", Element.NEUTRAL, 2);
            Boss B3 = new Boss(25, "Zoccoleta le souleveur", Element.NEUTRAL, 3);
            Boss B4 = new Boss(100, "Etoildidiavid le roi du Nez-land ", Element.NEUTRAL, 4);
            Boss B5 = new Boss(100, "Fapopille la fripouille", Element.WATER, 5);

            I_Damage a1 = new Attaque();
            I_Damage a2 = new MultDamage(a1, 2);
            I_Damage a3 = new AddDamage(a2, 5);
            I_Damage a4 = new MultDamage(a3, 4);
            I_Damage a5 = new AddElement(a4, Element.FIRE);
            I_Damage a6 = new AddElement(a5, Element.WATER);

            Console.WriteLine("Degats : " + a5.getDamage()); // 100
            Console.WriteLine("Element : " + a5.getElement()); //FEU
            Console.WriteLine("Ajout de l'element WATER :" + a6.getElement()); // 3
            Console.Read();
           
        }
    }
}
