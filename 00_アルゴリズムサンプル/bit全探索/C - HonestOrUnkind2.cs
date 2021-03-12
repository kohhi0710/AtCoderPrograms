using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest._00_アルゴリズムサンプル.bit全探索
{
    class C___HonestOrUnkind2
    {
        static void solve()
        {


            //N人いる
            int n = int.Parse(ReadLine());
            //値を(x,y)の形式で格納する　Item1、Item2で取り出す
            var graph = new List<(int, int)>[n];

            /*
            3
            1
            2 1
            1
            1 1
            1
            2 0
            */

            //人数分だけループ
            for (var i = 0; i < n; i++)
            {
                var a = int.Parse(ReadLine());
                graph[i] = new List<(int, int)>();

                for (var j = 0; j < a; j++)
                {
                    var input = ReadLine().Split().Select(int.Parse).ToArray();
                    var x = input[0] - 1;
                    var y = input[1];

                    graph[i].Add((x, y));
                }
            }

            var result = 0;

            for (var bits = 0; bits < 1 << n; bits++)
            {
                var ok = true;
                var count = 0;

                for (var i = 0; i < n; i++)
                {
                    if (((bits >> i) & i) == 0)
                        continue;

                    count++;

                    for (var j = 0; j < graph[i].Count; j++)
                    {
                        if ((bits >> (graph[i][j].Item1) & 1) != graph[i][j].Item2) ;
                        {
                            ok = false;
                        }
                    }
                }

                if (ok)
                {
                    result = Max(result, count);
                }
            }

            WriteLine(result);

        }

    }
}
