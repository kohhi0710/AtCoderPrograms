using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    //https://atcoder.jp/contests/abc155/tasks/abc155_b

    class B___Papers__Please
    {
        static void solve()
        {
            int N = int.Parse(ReadLine());
            string[] input = ReadLine().Split();
            bool hantei = true;

            //書類に書かれている数字の分だけループ
            for (int i = 0; i < N; i++)
            {
                //数字を精査
                int A = int.Parse(input[i]);

                //偶数か？
                if (A % 2 == 0)
                {
                    //3で割り切れない　かつ　5で割り切れない？
                    if (A % 3 != 0 && A % 5 != 0)
                    {
                        //入国条件を満たしてないのでfalse
                        hantei = false;
                    }
                }
            }

            if (hantei)
            {
                WriteLine("APPROVED");
            }
            else
            {
                WriteLine("DENIED");
            }
        }

    }
}
