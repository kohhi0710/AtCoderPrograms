using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoderTest
{
    //https://algoful.com/Archive/Algorithm/SelectionSort

    //対象データから最小値(or最大値)を選択・交換を繰り返すことでソートを行う
    //バブルソートと比較してデータの交換実施が少ないので高速なソートができる
    //「安定」な「内部」ソートである
    //計算量はO(n)^2で処理速度は低速

    class 選択ソート
    {
        public static void SelectionSort<T>(T[] array)where T : IComparable<T>
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                //最小値のインデックス保持用
                int min = i;
                
                //このループが終わればminには最小値のインデックスが入っている
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[min].CompareTo(array[j]) > 0)
                    {
                        min = j;
                    }
                }

                //見つかった最小値の値を交換
                Swap(ref array[min], ref array[i]);

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
