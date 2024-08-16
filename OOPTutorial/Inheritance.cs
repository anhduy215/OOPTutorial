using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // thể hiện tính kế thừa các thuộc tính phương thức của lớp cha qua lớp con
    public class Animal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("animal speak");
        }
    }
    // class dog kế thừa phương thức từ lớp cha animal
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("dog bark");
        }
    }

}
