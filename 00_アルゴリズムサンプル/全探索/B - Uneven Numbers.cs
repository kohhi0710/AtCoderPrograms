using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.全探索
{
    //https://atcoder.jp/contests/abc136/tasks/abc136_b

    class B___Uneven_Numbers
    {
        static void solve()
        {
            //Nの制限が10^5なので値は最大5桁までを検討する

            int N = int.Parse(ReadLine());
            int ans = 0;

            for(var i = 1; i <= N; i++)
            {
                //iが1～9であるとき(1桁　奇数)
                if (i >= 1 && i <= 9)
                {
                    ans++;
                }

                //iが100～999であるとき(3桁　奇数)
                if(i >=  100 && i <= 999)
                {
                    ans++;
                }

                //iが10000～99999であるとき(5桁　奇数)
                if (i >= 10000 && i <= 99999)
                {
                    ans++;
                }
            }

            WriteLine(ans);

        }
    }
}
