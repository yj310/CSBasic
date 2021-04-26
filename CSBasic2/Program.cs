﻿using System;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());
            if(input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("홀수!");
            }
            Console.WriteLine();

            // 시각 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            if (DateTime.Now.Hour == 12)
            {
                Console.WriteLine("점심시간입니다.");
            }
            if (DateTime.Now.Hour > 12)
            {
                Console.WriteLine("오후입니다.");
            }
            Console.WriteLine("\n===\n");




            // if elseif else
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간!");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간!");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간!");
            }






            Console.WriteLine();

            // switch 활용
            Console.Write("숫자를 입력하세요 : ");
            int input3 = int.Parse(Console.ReadLine());
            // magic number 주의
            const int ZERO = 0;
            const int ONE = 1;
            switch(input3 % 2)
            {
                case ZERO:
                    Console.WriteLine("짝수");
                    break;
                case ONE:
                    Console.WriteLine("홀수");
                    break;
            }



            Console.Write("이번 달은 몇 월인가요: ");
            int input4 = int.Parse(Console.ReadLine());
            switch(input4)
            {
                case 12: 
                case 1: 
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가울");
                    break;
                default:
                    Console.WriteLine("지구인가요?");
                    break;
            }














        }
    }
}
