using System;
using System.Collections.Generic;
using System.Text;

namespace LearningManagement
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

    }  

    internal class StudentGPAS: IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.GPA.CompareTo(y.GPA);
        }

    }


}







