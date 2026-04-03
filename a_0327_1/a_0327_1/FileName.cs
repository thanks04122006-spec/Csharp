using System;
using System.Collections.Generic;
using System.Text;

namespace a_0327_1
{
    internal class FileName
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("숫자를 입력하세요");

            //string s_input = Console.ReadLine();
            //int input = int.Parse(s_input);
            //int remain = input % 2;

            ////switch (remain)
            ////{
            ////    case 0:
            ////        Console.WriteLine("짝수입니다");
            ////        break;
            ////    case 1:
            ////        Console.WriteLine("홀수입니다");
            ////        break;

            //if (remain == 0)
            //{
            //    Console.WriteLine("짝수입니다");
            //}
            //else if (remain == 1)
            //{
            //    Console.WriteLine("홀수입니다");
            //}

            //Console.WriteLine("이번달은 몇월인가요");

            //int input = int.Parse(Console.ReadLine());

            //switch (input)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울입니다");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄입니다");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름입니다");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("가을입니다");
            //        break;
            //}

            //if (input == 12 || (input > 0 && input < 3))
            //{
            //    Console.WriteLine("겨울입니다");
            //}
            //else if (input <= 5)
            //{
            //    Console.WriteLine("봄입니다");
            //}
            //else if (input <= 8)
            //{
            //    Console.WriteLine("여름입니다");
            //}
            //else if (input <= 11)
            //{
            //    Console.WriteLine("가을입니다");
            //}
            //else Console.WriteLine("도대체 어떤행성?");

            //Console.WriteLine("입력:");

            //string line = Console.ReadLine();

            //if (line.Contains("안녕"))
            //{
            //    Console.WriteLine("안녕하세요");
            //}
            //else
            //{
            //    Console.WriteLine("^^");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("출력");
            //}
            int[] intArray = { 52, 273, 32, 65, 103 };
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //Console.WriteLine(intArray[i]);
            //}
            //int[] array = new int[100];

            //for (int i= 0; i < args.Length; i++)
            //{
            //    array[i] = i + 1;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //int cnt = 0;

            //while (cnt < intArray.Length)
            //{
            //    Console.WriteLine(cnt + "번째 출력" + intArray[cnt]);
            //    cnt++; // 없어지면 영원히 반복
            //}
            //string[] array = { "사과", "배", "포도", "ㄸㄹ기", "바나나" };

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
