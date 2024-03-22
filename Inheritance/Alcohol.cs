using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum alcoholType { Beer, Vodka, Soju };
    public class Alcohol : Drinks
    {
        public alcoholType type = alcoholType.Beer;
        public int strength = 0;

        public override String GetInfo()
        {
            var str = "Я алкоголь";
            str += base.GetInfo();
            str += String.Format("\nКрепость: {0}", this.strength);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }

        public static Alcohol Generate()
        {
            var rnd = new Random();
            return new Alcohol
            {
                volume = rnd.Next() % 100,
                type = (alcoholType)rnd.Next(3),
                strength = rnd.Next() % 100
            };
        }
    }
}
