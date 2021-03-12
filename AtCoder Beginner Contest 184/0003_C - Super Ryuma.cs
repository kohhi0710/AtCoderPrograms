using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest.AtCoder_Beginner_Contest_184
{
    class _0003_C___Super_Ryuma
    {
        static void solve()
        {
            string[] str1 = ReadLine().Split(); //r1,c1
            string[] str2 = ReadLine().Split(); //r2,c2
            long r = long.Parse(str1[0]);
            long c = long.Parse(str1[1]);

            r -= long.Parse(str2[0]);
            c -= long.Parse(str2[1]);

            int ans = 0;

            if (r == 0 && c == 0)
            {
                ans = 0;
            }
            else if (r == c || r + c == 0)
            {
                ans = 1;
            }
            else if (Abs(r) + Abs(c) <= 3)
            {
                ans = 1;
            }
            else if (Abs(r) + Abs(c) <= 6)
            {
                ans = 2;
            }
            else if (Abs(r) - Abs(c) <= 4 &&
                    Abs(r) - Abs(c) >= 4)
            {
                ans = 2;
            }
            else if ((r - c) % 2 == 0)
            {
                ans = 2;
            }
            else
            {
                ans = 3;
            }

            WriteLine(ans);
        }

    }
}
