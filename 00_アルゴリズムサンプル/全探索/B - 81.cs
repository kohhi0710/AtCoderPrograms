using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    class B___81
    {
        //https://atcoder.jp/contests/abc144/tasks/abc144_b

        static void solve()
        {
            int N = int.Parse(ReadLine());

            for(int i = 0; i < 10; i++)
            {
                //1～9で割り切れる　かつ　割ったあとの値が10以下である
                if (N % i == 0 && N / i < 10)
                {
                    WriteLine("Yes");
                    return;
                }
            }

            WriteLine("No");
        }
    }
}
