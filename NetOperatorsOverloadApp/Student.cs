using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOperatorsOverloadApp
{
    class Student
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        int[] labels = new int[5];

        public int this[int index]
        {
            set => labels[index] = value;
            get => labels[index];
        }

        public string this[string key]
        {
            get
            {
                switch(key)
                {
                    case "name": return Name;
                    case "email": return Email;
                    case "phone": return Phone;
                    default: return "";
                }
            }
            set
            {
                switch (key)
                {
                    case "name": Name = value; break;
                    case "email": Email = value; break;
                    case "phone": Phone = value; break;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}";
        }
    }

    class Group
    {
        public int Size { set; get; } = 3;
        Student[] students = new Student[3];

        /*
        public <ReturnType> this[type1 index1, ...]
        {
            set{...}
            get{...}
        }
        */

        public Student this[int index]
        {
            get => students[index];
            set => students[index] = value;
        }

    }


    class Matrix
    {
        int[,] items = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        public int this[int row, int column]
        {
            get => items[row, column];
            set => items[row, column] = value;
        }
    }
}
