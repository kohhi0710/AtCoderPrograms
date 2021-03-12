using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AtCoderTest._01_GoTo水色
{
    class _011_C___Switches
    {
        //https://atcoder.jp/contests/abc128/tasks/abc128_c

        static void solve()
        {
            var input = ReadLine().Split().Select(int.Parse).ToArray();
            var (N, M) = (input[0], input[1]); //N(スイッチの数)とM(電球の数)

            //電球の数の要素数をもつリスト
            List<int>[] s = new List<int>[M];

            //電球の数ループ
            //まず検証に使うリストを作成する
            for (var i = 0; i < M; ++i)
            {
                //読み取った値をそれぞれ -1 して配列にする
                //→0or1にすることでonとoffを表現する(bit全探索という手法)
                input = ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                //配列の最初の値(onになっているスイッチの数)を+1して変数kを作る
                var k = input[0] + 1;
                //二次元配列(リスト)
                s[i] = new List<int>();

                //onになっているスイッチの数ループ
                for (var j = 1; j <= k; ++j)
                {
                    //要素1からの値を入れる
                    s[i].Add(input[j]);
                }
            }

            //Pの読み取り
            var p = ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            //解答カウント
            var res = 0;

            //変数bitを宣言し、1をNだけ左シフトした値ループ
            //ex)N = 2の時、1 << 2で「4」になる
            for (int bit = 0; bit < (1 << N); ++bit)
            {
                //スイッチの数だけ要素数をもつbool型変数
                var switches = new bool[N];

                //Nだけループ
                for (var i = 0; i < N; ++i)
                {
                    //bitと1 << Nが0以上のとき(bitと1 <<Nの両方が条件を満たす必要がある)
                    //i = 0のときはシフトしないので1になる
                    if ((bit & (1 << i)) > 0)
                    {
                        switches[i] = true;
                    }
                }

                //bol型変数
                var allon = true;

                //Mだけループ
                for (var i = 0; i < M; ++i)
                {
                    //&=演算子:左辺と右辺のandをとる。
                    //allonはbool型で初期値はtrueなので、右辺がtrueならtrueになる。
                    //右辺がfalseならfalseになる。
                    allon &= (s[i].Where(x => switches[x]).Count() % 2 == p[i]);
                }

                if (allon == true)
                {
                    res++;
                }

            }

            WriteLine(res);

        }
    }
}
