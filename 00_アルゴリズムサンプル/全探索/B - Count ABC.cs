using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    class B___Count_ABC
    {
        static void solve()
        {
            var n = ReadLine();
            var s = ReadLine();
            var count = 0;

            //文字数の分だけ検査
            for(var i = 0; i < s.Length; ++i)
            {
                //i番目のインデックスからABCの文字があるかどうか
                //iと戻り値が一緒(検索開始位置からABCがある)場合、countを増やす
                if (s.IndexOf("ABC",i) == i)
                {
                    count++;
                }
            }

            WriteLine(count);
        }
    }
}
