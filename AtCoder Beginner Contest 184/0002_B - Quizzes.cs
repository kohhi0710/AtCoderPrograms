using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest.AtCoder_Beginner_Contest_184
{
    class _0002_B___Quizzes
    {
        static void solve()
        {
            int N, X; string S; //クイズ数、点数初期値、文字列
            var input = ReadLine().Split().Select(int.Parse).ToArray();
            N = input[0]; X = input[1];
            S = ReadLine();

            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'o')
                {
                    X++;
                }
                else
                {
                    if (X != 0)
                    {
                        X--;
                    }
                }
            }

            WriteLine(X);
        }

    }
}
