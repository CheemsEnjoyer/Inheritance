using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum sodaType { KindCola, Fanta, Pepsi };
    public class Soda : Drinks
    {
        public sodaType type = sodaType.KindCola;
        public int bubles = 0;

        public override String GetInfo()
        {
            var str = "Я газировка";
            str += base.GetInfo();
            str += String.Format("\nВид: {0}", this.type);
            str += String.Format("\nКоличество пузырьков: {0}", this.bubles);
            return str;
        }

        public static Soda Generate()
        {
            var rnd = new Random();
            return new Soda
            {
                volume = rnd.Next() % 100,
                type = (sodaType)rnd.Next(3),
                bubles = rnd.Next() % 100,
                Image = Properties.Resources.soda
            };
        }
    }
}
