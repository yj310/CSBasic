﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{

    class Products
    {
        private static List<string> products = new List<string>();

        public Products()
        {
            products.Add("짜장면");
            products.Add("짬뽕");
            products.Add("탕수육");
            products.Add("마파두부");
            products.Add("나가사키짬뽕");
            products.Add("꽃빵");

        }

        public string this[int i]
        {
            get { return products[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }


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
        class PointClass
        {
            public int x;
            public int y;

            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            // public string textB = "init";

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "";
            }

            public Point(int x, int y, string a)
            {
                this.x = x;
                this.y = y;
                this.testA = a;
            }
        }



        static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }




        static void Main(string[] args)
        {
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;
            pcB.x = 100;
            pcB.y = 200;
            Console.WriteLine(pcA.x + ", " + pcA.y);
            Console.WriteLine(pcB.x + ", " + pcB.y);
            Console.WriteLine();


            Point pA = new Point(10, 20);
            Point pB = pA;
            pB.x = 100;
            pB.y = 200;
            Console.WriteLine(pA.x + ", " + pA.y);
            Console.WriteLine(pB.x + ", " + pB.y);
            Console.WriteLine();


            Point point = new Point(10, 10);
            Point point2 = new Point();
            // point.x = 10;
            // point.y = 10;
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            Console.WriteLine(point2.x);
            Console.WriteLine(point2.y);
            Console.WriteLine();



            int x = 0;
            int y = 0;
            int vx = 100;
            int vy = 100;

            Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");



            Console.Write("숫자 입력: ");
            int output = int.MinValue;
            bool result = int.TryParse(Console.ReadLine(), out output);

            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!" + output);
            }
            Console.WriteLine();




            Products p = new Products();
            Console.WriteLine(p[2]);
            Console.WriteLine((new Products())[2]);
            Console.WriteLine();




            Wanted<string> wantedString = new Wanted<string>("스트링");
            Wanted<int> wantedInt = new Wanted<int>(3);
            Wanted<Student> wanteStudent = new Wanted<Student>(new Student());
        }
    }
}
