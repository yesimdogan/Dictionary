using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary2
{
    class MyDictionary2<StudentNo, Student>
    {
        StudentNo[] studentNos;
        Student[] students;
      

        public MyDictionary2()
        {
            studentNos = new StudentNo[0];
            students = new Student[0];  
        }

        public void Add(StudentNo studentNo, Student student)
        {

            StudentNo[] tempArray = studentNos;
            studentNos = new StudentNo[studentNos.Length + 1];

            for (int j = 0; j < tempArray.Length; j++)
            {
                studentNos[j] = tempArray[j];
            }

            studentNos[studentNos.Length - 1] = studentNo;


            Student[] tempArray2 = students;
            students = new Student[students.Length + 1];

            for (int i = 0; i < tempArray2.Length; i++)
            {
                students[i] = tempArray2[i];
            }

            students[students.Length - 1] = student;


        }
        public void List()
        {
            for (int y = 0; y < studentNos.Length ; y++)
            {
                Console.WriteLine("Student No " + " : "  + studentNos[y] +  " --> Student Name" + ":" +  students[y] + "\n");

            }

        }

        public void Count()
        {
            Console.WriteLine("Student Count:" + students.Length);
        }
    }
}
