using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_29082561
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2. instantiation of student
            student stu1 = new student();
            stu1.gender = "male";
            stu1.SetName("Pakon");
            stu1.SetGPA(3.5f);
            stu1.setID("58030205");
        }
    }

    // 1.Create class student
    class student
    {
        private string id;
        private string name;
        public string gender;
        private float gpa;

        public void SetName(string name)
        {
            this.name = name;
        }

        internal void SetGPA(float v)
        {
            throw new NotImplementedException();
        }

        internal void setID(string v)
        {
            throw new NotImplementedException();
        }
    }
}