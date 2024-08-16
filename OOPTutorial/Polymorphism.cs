using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // thể hiện tính đa hình bằng cách ghi đè các phương thức từ lớp cha cùng phương thức nhưng các lớp con mỗi lớp 1 cách hoạt động
    public class Animals
    {
        public virtual void MakeSound() // Phương thức ảo, có thể được ghi đè
        {
            Console.WriteLine("Some sound...");
        }
    }

    public class Dog2 : Animals
    {
        public override void MakeSound() // Ghi đè phương thức từ lớp cha
        {
            Console.WriteLine("gau gau");
        }
    }

    public class Cat : Animals
    {
        public override void MakeSound() // Ghi đè phương thức từ lớp cha
        {
            Console.WriteLine("meo meo");
        }
    }
}

