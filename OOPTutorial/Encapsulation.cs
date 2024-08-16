using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // thể hiện tính đóng gói tránh cho đối tượng bị truy cập hoặc thay đổi trực tiếp từ bên ngoài
    public class NhanVien
    {
        // các thuộc tính private chỉ có thể truy cập bên trong class
        private string ten;
        private int tuoi;
        private double luong;

        public NhanVien(string ten, int tuoi, double luong)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.luong = luong;
        }

        // các phương thức public để có thể hỗ trợ tương tác từ bên ngoài như getter setter...
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public int Tuoi
        {
            get { return tuoi; }
            set
            {
                if (value > 0 && value <= 100)
                    tuoi = value;
                else
                    Console.WriteLine("tuoi phai trong khoang 1 den 100");
            }
        }
        public double Luong
        {
            get { return luong; }
            set
            {
                if (value >= 0)
                    luong = value;
                else
                    Console.WriteLine("Luong khong duoc la so am");
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ten: {ten}, Tuoi: {tuoi}, Luong: {luong}");
        }

    }
}
