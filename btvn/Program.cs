using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    class account
    {
        private string id;
        private string ten;
        private int balance;
        public account(string id, string ten, int balance)
        {
            this.id = id;
            this.ten = ten;
            this.balance = balance;
        }

        public string getid()
        {

            return id;
        }
        public string getten()
        {

            return ten;
        }
        public int getbalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            balance += amount;
        }
        public void debit(int amount)
        {
            if (amount < balance)
                balance -= amount;
        }
        public void strasferto(account tk, int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                tk.balance += amount;

                Console.WriteLine("Quy khac da chuyen tien thanh cong :)   ");
            }
            else
                Console.Write(" xin loi quy khach khong thuc hien giao dich nay duoc:(  ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       thong tin tai khoan ban dau:    ");
            Console.Write("nhap so tai khoan mat khau thu nhat:");
            string id = Console.ReadLine();
            Console.Write("nhap ten cua tai khoan thu nhat:");
            string ten = Console.ReadLine();
            Console.Write("nhap so balance cua tai khoan: ");
            int balance = int.Parse(Console.ReadLine());
            account TK1cuatoi = new account(id, ten, balance);
            //tai khoan 1

            Console.Write("nhap so tai khoan mat khau thu nhat:");
            string id2 = Console.ReadLine();
            Console.Write("nhap ten cua tai khoan thu hai:");
            string ten2 = Console.ReadLine();
            Console.Write("nhap so balance cua tia khoan:");
            int balance2 = int.Parse(Console.ReadLine());
            account TK2cuatoi = new account(id, ten, balance);
            //tai khoan 2
            Console.WriteLine("       thong tin tai khoan ban dau:    ");
            Console.WriteLine($"tai khoan thu nhat :ID:{TK1cuatoi.getid()},ten:{TK1cuatoi.getten()},balace:{TK1cuatoi.getbalance()}:");
            Console.WriteLine($"tai khoan thu hai :{TK2cuatoi.getid()},{TK2cuatoi.getten()},{TK2cuatoi.getbalance()}:");
            TK1cuatoi.credit(100);
            TK1cuatoi.debit(200);
            TK1cuatoi.strasferto(TK2cuatoi, 50);
            // thong tin 2 tai khoan sao khi giao dich
            Console.WriteLine("       thong tin tai khoan sao khi giao dich:    ");
            Console.WriteLine($"tai khoan thu nhat :{TK1cuatoi.getid()},{TK1cuatoi.getten()},{TK1cuatoi.getbalance()}:");
            Console.WriteLine($"tai khoan thu hai :{TK2cuatoi.getid()},{TK2cuatoi.getten()},{TK2cuatoi.getbalance()}:");
            Console.ReadLine();
        }
    }
}
