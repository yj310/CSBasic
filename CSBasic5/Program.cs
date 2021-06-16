using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {

            MultiClass m1 = new MultiClass();

            Console.WriteLine(m1.Multi(52, 273));
            Console.WriteLine(m1.Multi(103, 32));
            Console.WriteLine();

            m1.Print();
            Console.WriteLine();

            Console.WriteLine(m1.Sum(1, 100));
            Console.WriteLine();

            MyMath.Abs(52);
            MyMath.Abs(273);
            MyMath.Abs(-453);
            Console.WriteLine();

            // MyMath.Abs(52.273);
            MyMath.Abs(52.273f);
            MyMath.Abs(300000000000);
            Console.WriteLine();




            m1.somePublic();
            // m1.someDefault();
            // m1.somePrivate();
            Console.WriteLine();



            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Console.WriteLine(productA.ToString());
            Console.WriteLine(productB.ToString());
            Console.WriteLine(Product.counter + "개 생성되었습니다.");
            Console.WriteLine();



            Console.WriteLine("첫 번째 위치");
            // Console.WriteLine(Sample.value);
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            // Sample sample = new Sample();
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
            Console.WriteLine();



            Box box = new Box(10, 10);
            box.Height = 100;
            box.Width = 200;
            box.Price = 3000;
            Console.WriteLine("박스의 면적은: " + box.Area);
            Console.WriteLine();



        }

        class Box
        {
            // 템플릿을 이용하면 편하다!!
            // prop
            // propfull
            public int some { get; set; }
            private int myVar;
            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }



            public int Price { get; set; }
            private int width;
            public int Width
            {
                get { return width; }
                set 
                {
                    if (value > 0)
                    {
                        this.width = value;
                    }
                    else
                    {
                        Console.WriteLine("너비는 양수를 입력해주세요.");
                    }
                }
            }

            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0)
                    {
                        this.height = value;
                    }
                    else
                    {
                        Console.WriteLine("높이는 양수를 입력해주세요.");
                    }
                }
            }

            public Box(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            private int area;
            public int Area
            {
                get { return this.width * this.height; }
            }


        }

        class Sample
        {
            public static int value;

            // class 가 처음 로드될 때 실행
            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }

        class Product
        {
            public static int counter = 0;
            public readonly int id; // 생성자에서만 딱 1번 변경 가능
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = Product.counter + 1;
                this.id = Product.counter;
                // this.id = ++Product.counter;

                this.name = name;
                this.price = price;
            }

            ~Product()
            {
                Console.WriteLine(this + "의 소멸자가 호출되었습니다.");
                Console.WriteLine(this.name + "曰: \"안녕히 계세요 여러분~\"");
            }

            public override string ToString()
            {
                return id + ": " + name;
            }
        }

        class MyMath
        {
            /*public static void Abs(int input)
            {
                Console.WriteLine("int: " + ((input < 0) ? -input : input));
            }*/
            /*
            public static void Abs(double input)
            {
                Console.WriteLine("double: " + ((input < 0) ? -input : input));
            }*/

            public static void Abs(float input)
            {
                Console.WriteLine("float: " + ((input < 0) ? -input : input));
            }

            /*public static void Abs(long input)
            {
                Console.WriteLine("long: " + ((input < 0) ? -input : input));
            }*/
        }

        class MultiClass
        {
            public void somePublic()
            {
                Console.WriteLine("public!");
            }

            void someDefault()
            {
                Console.WriteLine("Default!");
            }

            private void somePrivate()
            {
                Console.WriteLine("private!");
            }


            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출!");
            }

            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}
