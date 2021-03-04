using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    class Nguoi
    {
        private string ten;
        private string diaChi;
        private int tuoi;

        public Nguoi(string ten, string diaChi, int tuoi)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
        }

        public Nguoi()
        {
        }

        public void Nhap()
        {
            Console.WriteLine("nhap ten:");
            this.ten = Console.ReadLine();
            Console.WriteLine("nhap diachi:");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("nhap tuoi:");
            this.tuoi = Int32.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("Ten: " + this.ten + " dia chi: " + this.diaChi + " tuoi: " + this.tuoi);
           
        }

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }


    }
}
