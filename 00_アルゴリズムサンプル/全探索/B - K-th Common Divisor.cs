using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    class B___K_th_Common_Divisor
    {
        static void solve()
        {
            var input = ReadLine().Split().Select(int.Parse).ToArray();

            var A = input[0];
            var B = input[1];
            var K = input[2];

            var result = 0;
            var r = 0;

            //A,Bのうち、小さい値からスタートしデクリメントループ
            //ループ終了条件は設けない
            for (var i = Min(A, B); ; i--)
            {
                //Aをiで割り切れる　かつ　Bをiで割り切れる
                if (A % i == 0 && B % i == 0)
                {
                    //rを増加(r番目に大きい 1番目からスタート)
                    r++;

                    //Kとrが同じ値の時
                    if (K == r)
                    {
                        //その時のiの値をresultに入れてループ終了
                        result = i;
                        break;
                    }
                }
            }

            WriteLine(result);

        }
    }
}
