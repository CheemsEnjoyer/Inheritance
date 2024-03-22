using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum FruitType { apple, orange,grape };
    public class Juice : Drinks
    {
        public FruitType type = FruitType.apple;
        public bool hasPulp = false;

        public override String GetInfo()
        {
            var str =  "Я сок";
            str += base.GetInfo();
            str += String.Format("\nФрукт: {0}", this.type);
            str += String.Format("\nНаличие мякоти: {0}", this.hasPulp);
            return str;
        }

        public static Juice Generate()
        {
            var rnd = new Random();
            return new Juice
            {
                volume = rnd.Next() % 100,
                type = (FruitType)rnd.Next(3),
                hasPulp = rnd.Next() % 2 == 0   
            };
        }
    }
}
