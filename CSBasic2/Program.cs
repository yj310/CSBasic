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














        }
    }
}