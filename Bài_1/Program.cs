using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bài_1
{
    class Rectangle
    {
        public double length;
        public double width;
        public Rectangle()
        {
            this.width = 1.0;
            this.length = 1.0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double length) 
        {
            this.length = length;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getWidth()
        {
            return width;
        }
        public double findArea()
        {
            return length*width;
        }
        public double findPerimeter() { return (length+width)*2; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("nhap chieu dai chieu rong hinh chu nhat:");
            Console.WriteLine(" cho biet chieu dai:");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("cho biet chieu rong:");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("$ hinh chu nhat:chieu dai:{0},chieu rong{1},dien tich:{2},chu vi{0}",
                                r1.getLength(),r1.getWidth(),r1.findArea(),r1.findPerimeter());
            Rectangle r2 = new Rectangle(d, R);
            Console.WriteLine("hinh chu nhat:chieu dai:{0},chieu rong{1},dien tich:{2},chu vi{0}",
                                r2.getLength(), r2.getWidth(), r2.findArea(), r2.findPerimeter());
            Console.ReadLine();

        }
    }
}
