using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_w06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student.Change();//calling change method
                             //creating objects
            student s1 = new student(111, "Hoang");
            student s2 = new student(222, "Khanh");
            student s3 = new student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
            Console.ReadKey();
        }
    }
}
