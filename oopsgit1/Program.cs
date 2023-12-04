using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsgit1
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            student s1 = new student("harish", 1001, 21, "trichy");
            student s2 = new student("ansu", 1002, 21, "trichy");
            student s3=  new student("malis", 1003, 21, "trichy");

            s.addstudent(s1);
            s.addstudent(s2);
            s.addstudent(s3);
            s.displaystudent();

        }
    }
}
