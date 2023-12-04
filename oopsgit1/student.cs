 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsgit1
{
    public  class student
    {
        string name;

        int rollno;
        int age;
        string address;
        List<student> studlist = new List<student>();
        public student()
        {
        }
        public student(string name,int rollno,int age,string address)
        {
            this.name=name;
            this.rollno = rollno;

            this.age=age;
            this.address = address;

        }
        public void addstudent(student stud)
        {
            studlist.Add(stud);
        }
        public void displaystudent()
        {
            foreach (student stud in studlist)
            {
                Console.WriteLine(stud);
            }
        }
        public override string ToString()
        {
            return this.name + "-" + this.age + "-" + this.rollno + "-" + this.address;
        }
        

    }
}
