using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoderTest._01_GoTo水色
{
    //https://atcoder.jp/contests/s8pc-6/tasks/s8pc_6_b

    class _008_B___AtCoder_Market
    {
        /// <summary>
        /// 天才のプログラム
        /// </summary>
        static void solve()
        {
            //買い物客数
            int N = int.Parse(Console.ReadLine());
            //マスA(買うものA)  買い物客数だけ要素数設定
            int[] A = new int[N];
            //マスB(買うものB)  買い物客数だけ要素数設定
            int[] B = new int[N];

            //買い物客分だけループで標準入力読みとり
            for(var i = 0; i < N; i++)
            {
                string[] str2 = Console.ReadLine().Split();
                A[i] = int.Parse(str2[0]);
                B[i] = int.Parse(str2[1]);
            }

            //買うものの座標を昇順ソート
            Array.Sort(A);
            Array.Sort(B);

            int a1 = 0;
            int a2 = 0;

            //座標を順番に並べたもののうち、中央値がそれぞれの座標の最適な中央値といえる
            //Aに対しての入口、Bに対しての出口と別々に考察する

            //客数が奇数のとき
            if(N % 2 == 1)
            {
                //(客数 - 1) / 2の位置の座標の値を入れる
                //Aの座標配列の中央値となるもの
                a1 = A[(N - 1) / 2];
                a2 = B[(N - 1) / 2];
            }
            //客数が偶数のとき
            else
            {
                //客数 / 2の位置の座標の値を入れる
                //Bの座標配列の中央値となるもの
                a1 = A[N / 2];
                a2 = B[N / 2];
            }

            //答え用の変数
            long ans = 0;

            //客数だけループ
            for(var i = 0; i < N; i++)
            {
                //Aからa1(中央値)を引いた値をansに足す→Aから入口の距離
                ans += Math.Abs(A[i] - a1);
                //BからAを引いた値をansに足す→BからAの距離
                ans += Math.Abs(B[i] - A[i]);
                //a2(中央値)からBを引いた値をansに足す→Bから出口の距離
                ans += Math.Abs(a2 - B[i]);
            }

            Console.WriteLine(ans);
        }

        static void solve2()
        {
            var N = int.Parse(ReadLine());
            var A = new long[N];
            var B = new long[N];

            for(int i = 0; i < N; i++)
            {
                var l = ReadLine().Split().Select(int.Parse).ToArray();
                A[i] = l[0];
                B[i] = l[1];
            }

            Array.Sort(A);
            Array.Sort(B);

            var ans = 0L;

            for(int i = 0; i < N; i++)
            {
                ans += Abs(A[i] - A[N / 2]);
                ans += Abs(B[i] - B[N / 2]);
                ans += B[i] - A[i];
            }

            WriteLine(ans);

        }

        static void solve3()
        {
            var N = int.Parse(ReadLine());
            var A = new long[N];
            var B = new long[N];

            for(int i = 0; i < N; i++)
            {
                var input = ReadLine().Split().Select(p => int.Parse(p)).ToArray();
                A[i] = input[0];
                B[i] = input[1];
            }

            long in_A;
            long B_out;
            long ans = 0;

            Array.Sort(A);
            Array.Sort(B);

            in_A = A[N / 2];
            B_out = B[N / 2];

            for(int i = 0; i < N; i++)
            {
                ans += Abs(A[i] - B[i]);
                ans += Abs(A[i] - in_A);
                ans += Abs(B[i] - B_out);
            }

            WriteLine(ans);
        }
    }
}
