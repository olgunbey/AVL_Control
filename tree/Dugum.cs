using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Dugum
    {
        internal int veri;
        internal Dugum right;
        internal Dugum left;
        internal int yukseklik;
        public Dugum(int y)
        {
            this.veri = y;
            this.yukseklik = 1;
        }
    }
}
