using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inheritance
{
    public class Drinks
    {
        public static Random rnd = new Random();
        public int volume = 0;
        public Image Image { get; set; }
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъём: {0}", this.volume);
            return str;
        }
    }
}
