using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    //https://atcoder.jp/contests/abc154/tasks/abc154_b

    class B___I_miss_you
    {
        static void solve()
        {
            string[] ab = ReadLine().Split();

            //入力値を昇順ソート
            Array.Sort(ab);
            string ans = null;

            //b値の分だけループ
            for (int i = 0; i < int.Parse(ab[1]); i++)
            {
                //a値をansの末尾にループの数だけ足していく
                ans += ab[0];
            }

            WriteLine(ans);

        }

    }
}
