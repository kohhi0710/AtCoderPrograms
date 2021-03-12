using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    class B___Strings_with_the_Same_Length
    {
        static void solve()
        {
            var N = int.Parse(ReadLine());
            var input = ReadLine().Split();

            //文字列S
            var s = input[0];
            //文字列T
            var t = input[1];

            var ans = "";

            //文字数だけループ
            for (var i = 0; i < N; i++)
            {
                //ansにそれぞれの文字列を一文字ずつ足していく
                ans += s[i];
                ans += t[i];
            }

            WriteLine(ans);
        }

    }
}
