using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    class Student
    {
        public string name;
        public string major;
        public int gpa;

        public Student(string aName, string aMajor, int aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonours()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }


    }
}
