using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class DengeliTree
    {
       public  Dugum koks = null;
        internal int getYukseklik(Dugum kok)
        {
            if(kok==null)
            {
                return 0;
            }
            return kok.yukseklik;
        }
        internal int getBalance(Dugum kok)
        {
            if(kok==null)
            {
                return 0;
            }
            return getYukseklik(kok.left) - getYukseklik(kok.right);
        }

        public Dugum soladon(Dugum kok)
        {
            Dugum pr = kok.right;
            Dugum prl = pr.left;

            //dondurme

            pr.left = kok;
            kok.right = prl;

            // yukseklık guncel
            kok.yukseklik = Math.Max(getYukseklik(kok.left),getYukseklik(kok.right))+1;
            pr.yukseklik = Math.Max(getYukseklik(pr.left), getYukseklik(pr.right)) + 1;

            return pr; //yeni kok pr
        }
        public Dugum sagadon(Dugum kok)
        {
            Dugum pl = kok.left;
            Dugum plr = pl.right;

            //dondurme

            pl.right = kok;
            kok.left = plr;

            //yukseklık guncelleme
            kok.yukseklik = Math.Max(getYukseklik(kok.left), getYukseklik(kok.right)) + 1;
            pl.yukseklik = Math.Max(getYukseklik(pl.left), getYukseklik(pl.right)) + 1;

            return pl;
        }
       public void insert(int deger)
        {
            this.koks = Degerekle(this.koks,deger);
        }
        public Dugum Degerekle(Dugum kok,int deger)
        {
            if (kok == null)
            {
             return  new Dugum(deger);
                
            }
            if(deger<kok.veri)
            {
                kok.left = Degerekle(kok.left,deger);
            }
            if(deger>kok.veri)
            {
                kok.right = Degerekle(kok.right, deger);
            }

            // yukseklık guncel
            kok.yukseklik = Math.Max(getYukseklik(kok.left),getYukseklik(kok.right))+1;

            int bf = getBalance(kok);

            //LL dengesizligi
            if(bf>1 && deger<kok.left.veri)
            {
                return sagadon(kok);
            }

            //RR DENGESIZLIGI
            if(bf<-1 && deger>kok.right.veri)
            {
                return soladon(kok);
            }
            //LR dengesızlıgı
            if(bf>1 && deger>kok.left.veri)
            {
                kok.left = soladon(kok.left);
                return sagadon(kok);
            }
            //RL dengesizligi
            if(bf<-1 && deger<kok.right.veri)
            {
                kok.right = sagadon(kok.right);
                return soladon(kok);
            }

            return kok;
        }

        public void ara(int deger)
        {
            Dugum tmp=this.koks;
            while(tmp!=null)
            {
                if (deger == tmp.veri)
                {
                     System.Windows.Forms.MessageBox.Show("KULLANILAMAZ ID");
                    break;
                }
                else if (deger < tmp.veri)
                {
                    tmp = tmp.left;
                    }
                else if (deger > tmp.veri)
                {
                    tmp = tmp.right;
                }
            }
            if(tmp==null)
            {
                System.Windows.Forms.MessageBox.Show("KULLANILABILIR ID");
            }
                
            
            

        }
        
    }
}
