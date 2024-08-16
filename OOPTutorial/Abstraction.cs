using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    public abstract class Shape
    {
        public abstract void Draw();// phương thức trừu tượng không có nội dung
    }

    public class Circle : Shape
    {
        public override void Draw()// cài đặt nội dung từ phương thức trừu tượng
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
