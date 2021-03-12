using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest.AtCoder_Beginner_Contest_184
{
    class _0001_A___Determinant
    {
        static void solve()
        {
            int a,b,c,d,result;

            var input = ReadLine().Split().Select(int.Parse).ToArray();
            a = input[0]; b = input[1];
            input = ReadLine().Split().Select(int.Parse).ToArray();
            c = input[0]; d = input[1];

            result = a * d - b * c;
            WriteLine(result);

        }
    }
}
