using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A023_ListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            //for (int x=0; x< 10; x++)
            //{
            //    int a = r.Next();
            //    int b = r.Next(100);
            //    int c = r.Next(10, 20);
            //    double d = r.NextDouble(); // 0에서 1사이의 소수점

            //    //Console.WriteLine(a.ToString()+" "+b.ToString()+" " + c.ToString()+ " " + d.ToString());
            //    //Console.WriteLine("{0},{1},{2},{3}", a, b, c, d);
            //    //Console.WriteLine($"{a},{b},{c},{d}");
            //    string t = string.Format("{0:N0},{1,10},{2,10},{3,10:F3}", a, b, c, d); // 3자리마다 콤마 {0:N0} / 10자리로 찍을 때{0,10} / 소수점 3자리 {3:F3} / 소수점 3자리까지 10자리 {3,10:F3}
            //    Console.WriteLine(t);
            //}

            //// 두 개의 주사위를 100번 던져서 합이 얼마인지 출력하라

            //for(int cnt =0; cnt < 100; cnt++) {

            //    Console.WriteLine("{0}", r.Next(1, 7) + r.Next(1, 7));
            //}

            //  두 개의 주사위를 1000000번 던져서 각각의 합이 몇번씩 나왔는지 출력하시오.
            //int[] cnt = new int[13]; // 배열이 필요하다 [13]개짜리

            //for (int i = 0; i < 1000000; i++)
            //{
            //    cnt[r.Next(1, 7) + r.Next(1, 7)]++;

            //}
            ////출력
            //for(int i=2;i<13;i++)
            //{
            //    Console.WriteLine("{0,2} : {1}",i,cnt[i]);
            //}
            //Console.WriteLine("foreach array");
            //foreach (var item in cnt)
            //{
            //    Console.WriteLine(item);
            //}

            // 리스트는 크기가 정해져 있지 않다는 장점이 있다.
            // 리스트: Generic <T> List <T>
            //List<int> lst = new List<int>();
            //for(int i = 0; i < 10; i++)
            //{
            //    lst.Add(r.Next(100));
            //}
            //// 배열은 for 리스트는 foreach로 쓰는게 일반적인 방법
            //foreach (var item in lst) 
            //{
            //    Console.WriteLine(item);
            //}
            //for(int i = 0; i < 10; i++)
            //    Console.WriteLine(lst[i]); // 마치 배열처럼

            // 10개짜리 문자열 배열 s1과 문자열 리스트 s2를 만드시오
            string[] s1 = new string[10];
            List<string> s2 = new List<string>();

            // 문자열 10개를 콘솔에서 입력받아서 배열과 리스트에 저장
            Console.WriteLine("문자열 10개를 입력하세요");
            for(int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                s1[i] = s;
                s2.Add(s);
            }
            // 문자열 10개를 출력
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,20},{1,20}",s1[i],s2[i]);
            }
            // 정렬하여 출력하기
            Array.Sort(s1); //배열
            s2.Sort(); //리스트

            Console.WriteLine("배열과 리스트 정렬 후 출력");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,20},{1,20}", s1[i], s2[i]);
            }
        }
    }
}
