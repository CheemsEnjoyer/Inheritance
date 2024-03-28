using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum TeaType { black, green};
    public class Tea : Drinks
    {
        public TeaType type = TeaType.black;
        public bool isIndian = false;

        public override String GetInfo()
        {
            var str = "Я чай";
            str += base.GetInfo();
            str += String.Format("\nЦвет: {0}", this.type);
            str += String.Format("\nНаличие мякоти: {0}", this.isIndian);
            return str;
        }

        public static Tea Generate()
        {
            var rnd = new Random();
            return new Tea
            {
                volume = rnd.Next() % 100,
                type = (TeaType)rnd.Next(2),
                isIndian = rnd.Next() % 2 == 0,
                Image = Properties.Resources.tea
            };
        }
    }
}
