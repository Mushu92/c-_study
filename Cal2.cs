using System;

namespace ConsoleApp1
{
    class Cal2
    {
        static void Main()
        {
            int flag;
            System.Console.Write("---------------------------------------------------\n");
            System.Console.Write("두 수를 입력받아서 원하는 연산을 취하는 프로그램입니다.\n");
            System.Console.Write("1: +\n");
            System.Console.Write("2: -\n");
            System.Console.Write("3: *\n");
            System.Console.Write("4: /\n");
            System.Console.Write("5: %\n");
            System.Console.Write("0: 프로그램 종료\n");
            System.Console.Write("----------------------------------------------------\n");
            do
            {
                System.Console.Write("Flag입력: ");
                flag = int.Parse(System.Console.ReadLine());
                if (flag == 0)
                {
                    Console.WriteLine("프로그램 종료");
                    return;
                }
                System.Console.Write("두 수를 한줄에 입력해주세요 ex)2 3: ");
                int A, B;
                string s = Console.ReadLine();
                string[] str = s.Split(' ');
                while (str.Length != 2)
                {
                    Console.WriteLine("잘못된 입력입니다. 정확히 입력해주세요 ex)2 3");
                    s = Console.ReadLine();
                    str = s.Split(' ');
                }
                A = int.Parse(str[0]);
                B = int.Parse(str[1]);
                switch (flag)
                {
                    case 1:
                        Console.WriteLine(A + B);
                        break;
                    case 2:
                        Console.WriteLine(A - B);
                        break;
                    case 3:
                        Console.WriteLine(A * B);
                        break;
                    case 4:
                        Console.WriteLine(A / B);
                        break;
                    case 5:
                        Console.WriteLine(A % B);
                        break;
                    default:
                        Console.WriteLine("없는 플래그");
                        break;
                }
            } while (flag != 0);
        }
    }
}
