using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLista2
{
    internal class Coisa
    {
        private int x;
        private string y;
        public int X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
        public Coisa(int x, string y)
        {
            this.x = x;
            this.y = y;
        }
        public Coisa(int x): this(x, "")
        {
        }
        public Coisa(): this(0,"")
        { 
        }
        public override string ToString()
        {
            return "X = " + this.x.ToString() + " - Y = " + this.y;
        }

        public override bool Equals(object obj)
        {
            return this.x == ((Coisa)obj).x;
        }

    }
}
