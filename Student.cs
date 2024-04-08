using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LamdaAndLinq
{
    internal class Student
    {
        public string StudentName { get; set; }
        public  int StudentId { get; set; }
        public List<char> Grades { get; set; }


        public Student (string StudentName,int StudentId,List<char> Grades)
        {
           this. StudentName = StudentName;
          this.  StudentId = StudentId;
            this.Grades = Grades;

        }

        //public double CalculateAvgGrade()
        //{
        //    return Grades.Average();
        //}

        public int GetHighestGrade()
        {
            return Grades.Max();
        }

        public int GetLowestGrade()
        {
            return Grades.Min();
        }
    }
}
