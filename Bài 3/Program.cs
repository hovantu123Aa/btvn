using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        // cau a
        class PhanSo
        {
            private int TuSo;
            private int mauSo;
            public PhanSo()
            {
                TuSo = 0;
                mauSo = 1;

            }
            public PhanSo(int TuSo, int MauSo)
            {
                this.TuSo = TuSo;
                this.mauSo = MauSo;
            }
            public void setTuSo(int TuSo)
            {
                this.TuSo = TuSo;
            }
            public int getTuSo()
            {
                return TuSo;
            }
            public void setMauSo(int MauSo)
            {

                this.mauSo = MauSo;
            }
            public int getMauSo()
            {
                return mauSo;
            }
            public void ToiGian()
            {
                int ucln = TimUCLN( TuSo, mauSo);
                TuSo = TuSo / ucln;
                mauSo = mauSo / ucln;
            }
            private int TimUCLN(int  a,int  b)
            {
                int x = Math.Abs(a);
                int y = Math.Abs(b);
                while (x != y)
                {
                    if (x > y)
                        x = x - y;
                    else
                        y = y - x;
                }
                return x;

            }
            public PhanSo cong(PhanSo ps)
            {
                PhanSo kq = new PhanSo();
                kq.TuSo = TuSo * ps.mauSo + ps.TuSo * ps.mauSo;
                kq.mauSo = mauSo * ps.mauSo;
                return kq;
            }
        }
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            Console.WriteLine("Nhap thong tin phan so thu nhat:");
            Console.Write("nhap tu so :");
            int TuSo=int.Parse(Console.ReadLine());
            Console.Write("nhap Mau so:");
            int MauSo=int .Parse(Console.ReadLine());
            p1.setTuSo(TuSo);
            p1.setMauSo(MauSo);
            Console.WriteLine(" Nhap thong tim phan so thu hai:");
            Console.Write("nhap tu so:");
            TuSo=int .Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            MauSo=int .Parse(Console.ReadLine());
            PhanSo p2 = new PhanSo(MauSo,TuSo);
            PhanSo tong=p1.cong(p2);
            tong.ToiGian();
            Console.WriteLine("tong hai phan so PS1:{0}/{1},PS2:{2}/{3},tong={4}/{5}"
                              ,p1.getTuSo(),p1.getMauSo(),p2.getTuSo(),p2.getMauSo(),tong.getTuSo(),tong.getMauSo());
            Console.ReadLine();
            // cau b
            Console.WriteLine(" Tinh toan day phan so:");
            Console.Write("Nhap vao so nguyen duong:");
            int n=int .Parse(Console.ReadLine());   
            PhanSo s = new PhanSo(0,1);
            for(int i=1;i<=n; i++)
            {
                s = s.cong(new PhanSo(1, i));

            }
            Console.WriteLine("ket qua day phan so:1+1/2+1/3+..1/n={0}/{1}", s.getTuSo(), s.getMauSo());
            Console.ReadLine();
               
                
               
        }
    }
}
