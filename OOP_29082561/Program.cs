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
            student stu1 = new student("58030205", "Pakon", "male", 0.0f);
        }
    }

    // 1.Create class student
    class student
    {
        private string id;
        private string name;
        public string gender;
        private float gpa;

        // Constructer
        public student(string v1, string v2, string v3, float v4)
        {
            this.id = v1;
            this.name = v2;
            this.gender = v3;
            this.gpa = v4;
        }
    }
}