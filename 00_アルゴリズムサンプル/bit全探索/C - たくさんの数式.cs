using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace AtCoderTest._00_アルゴリズムサンプル.bit全探索
{
    class C___たくさんの数式
    {
        //https://atcoder.jp/contests/abc045/tasks/arc061_a

        static void solve()
        {
            var input = ReadLine();
            var len = input.Length;
            double ans = 0;

            //ループ上限：2を入力文字数で累乗した値
            //→2^nと同義(1 << nも同じ)。つまり全パターン数。
            for(int bit = 0; bit < Math.Pow(2,len - 1); bit++)
            {
                var str = input[0].ToString();

                for(int j = 0; j < len - 1; j++)
                {
                    //右シフト(減る)
                    if ((bit >> j & 1) == 1)
                    {
                        ans += double.Parse(str);
                        str = input[j + 1].ToString();
                    }
                    else
                    {
                        str += input[j + 1].ToString();
                    }
                }

                ans += double.Parse(str);
            }

            WriteLine(ans);

        }
    }
}
