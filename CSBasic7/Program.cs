﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Wanted<T>
        // where T : Student
    {
        public T Value;
        public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class Student
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wantedInt = new Wanted<int>(3);
            Wanted<Student> wanteStudent = new Wanted<Student>(new Student());
        }
    }
}
