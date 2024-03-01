using System;

namespace bai3_w06
{
    public class student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";    
        public student(int r, string n)
        {
            rollno = r;
            name = n;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
