using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    class C___Digits_in_Multiplication
    {
        //https://atcoder.jp/contests/abc057/tasks/abc057_c

        static void solve()
        {
            var N = long.Parse(ReadLine());
            //ansにlong型の上限値を入れる
            var ans = long.MaxValue;

            //iはlong型の1からスタート
            //終了条件：iの2乗がNに到達する(iとiの2乗は両方ともNの約数であるため)
            for (var i = 1L; i * i <= N; i++)
            {
                //Nをiで割り切れる時
                if (N % i == 0)
                {
                    ans = Min(Max(i.ToString().Length,          //iの桁数
                                  (N / i).ToString().Length),　 //N / iの桁数
                              ans);
                }
            }

            WriteLine(ans);
        }
    }
}
