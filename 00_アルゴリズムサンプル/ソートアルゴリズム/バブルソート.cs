using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoderTest
{
    //https://algoful.com/Archive/Algorithm/BubbleSort#sample-cs

    //一番基本的なソートアルゴリズム
    //隣合う要素を比較しながら整列させていくことで、最終的にソートされたデータが得られる
    //アルゴリズムが単純で実装が容易だが、要素の比較・交換の回数が多く処理速度が低速になる
    //「安定」な「内部」ソートである
    //最終的には昇順(or降順)に整列する

    class バブルソート
    {
        public static void BubbleSort<T>(T[] array)where T : IComparable<T>
        {
            int n = array.Length;

            //最終要素を除いて全て比較する
            for(int i = 0; i < n; i++)
            {
                //最終要素から、現在比較中の要素までループ
                //このループが終わればarray[i]にはソート済データが入っている
                for(int j = n - 1; i < j; j--)
                {
                    // j番目の要素が一つ前の要素より小さければスワップ
                    if(array[j].CompareTo(array[j - 1]) < 0)
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}
