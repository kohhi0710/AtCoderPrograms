using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoderTest
{
    //https://algoful.com/Archive/Algorithm/ShellSort

    //挿入ソートを改良したアルゴリズム
    //間隔の離れた要素同士をソートし、段々間隔を小さくして、
    //最終的には隣り合った要素でソートする
    //→挿入ソートをそのまま行うより間隔をあけてざっくり行うほうが高速に処理できる
    //「不安定」な「内部」ソートである

    class シェルソート
    {
        //★重要★ -間隔hの決め方-
        //このhの決め方が適当であると、通常の挿入ソートより時間がかかってしまう可能性がある
        //hi + 1 = 3hi + 1を満たすhを大きい順から採用する

        public static void ShellSort<T>(T[] array)where T : IComparable<T>
        {
            int n = array.Length;
            int h = 0;

            //hがn / 9に達するまでループ(n / 9は切り捨て)
            //ex)n = 10のとき、h <= 1が成立する間はループ
            while(h <= n / 9)
            {
                //3h + 1の数式でhの値をセットする
                h = 3 * h + 1;
            }

            //3h + 1で間隔を決める
            for(; h > 0; h /= 3)
            {
                //間隔hで挿入ソート
                //最終的に通常の挿入ソート(h = 1)が実行されて完了
                for(int i = h; i < n; i++)
                {
                    //tmpに値を退避
                    var tmp = array[i];

                    if(array[i - h].CompareTo(tmp) > 0)
                    {
                        int j = i;

                        do
                        {
                            array[j] = array[j - h];
                            j -= h;
                        }
                        while (j >= h && array[j - h].CompareTo(tmp) > 0);

                        array[j] = tmp;
                    }
                }
            }
        }
    }
}
