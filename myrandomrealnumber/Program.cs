using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rnum = random.Next() % 100;
            while (true)
            {
                Console.Write("숫자를 입력해주세요 : ");
                int num = int.Parse(Console.ReadLine());

                if (rnum == num)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else if (rnum > num)
                {
                    Console.WriteLine(num + "보다 큰 숫자입니다");
                }
                else
                {
                    Console.WriteLine(num + "보다 작은 숫자입니다");
                }
            }
        }
    }
}
