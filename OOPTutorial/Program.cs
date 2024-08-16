using Encapsulation;
using Inheritance;
using Polymorphism;
using Abstraction;

public class Program
{
    static void Main(string[] args) {
        // Sử dụng đa hình(polymorphism)------------------------------------------------------
        Console.WriteLine("đa hinh:");
        List<Animals> animals = new List<Animals>
        {
            new Dog2(),
            new Cat()
        };

        
        foreach (var animal in animals)
        {
            animal.MakeSound(); // mỗi 1 loài vật sẽ được ghi đè lên phương thức chung của lớp animals thể hiện tính đa hình
        }

        // sử dụng kế thừa(inheritance)-------------------------------------------------------
        Console.WriteLine();
        Console.WriteLine("ke thua:");
        Dog dog = new Dog();
        dog.Name = "dog name";// name và speak là của lớp cha được lớp con kế thừa lại nên lớp con cũng có
        dog.Speak();
        dog.Bark();

        // sử dụng đóng gói(encapsulation) ---------------------------------------------------
        Console.WriteLine();
        Console.WriteLine("dong goi:");
        // Tạo một đối tượng của lớp NhanVien
        NhanVien nhanVien = new NhanVien("Nguyen Van A", 30, 5000);

        nhanVien.HienThiThongTin();

        // Thay đổi các thuộc tính qua các phương thức setter
        nhanVien.Ten = "Nguyen Van B";
        nhanVien.Tuoi = 35;
        nhanVien.Luong = 6000;

        // Hiển thị thông tin nhân viên sau khi thay đổi
        nhanVien.HienThiThongTin();
        
        nhanVien.Tuoi = -5;// Thử gán các giá trị không hợp lệ
        nhanVien.Luong = -1000;

        // sử dụng trừu tượng(abstraction)-----------------------------------------------------
        Console.WriteLine();
        Console.WriteLine("truu tuong:");
        
        Shape shape = new Circle();
        shape.Draw();
    }
}
