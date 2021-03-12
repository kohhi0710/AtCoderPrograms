using System;
using System.Collections.Generic;
using System.Text;

namespace AtCoderTest
{
    //https://algoful.com/Archive/Algorithm/SelectionSort

    //データ(array)の先頭要素をソート済のデータとして考える
    //i = 1からnまでループし、i番目の要素を挿入することを考える
    //j = iから0までループし、i番目の要素の挿入位置(array[i] > array[j]となるj)を決定

    class 挿入ソート
    {
        public static void insertionSort<T>(T[] array)where T : IComparable<T>
        {
            //array[0]をソート済部分として、以降のデータを挿入していく
            //ex)9 4 0 4 9 6 3 2 0 3
            for (int i = 1; i < array.Length; i++)
            {
                //挿入対象のデータを保持
                //ex)array[1]の4を保持
                var tmp = array[i];

                //ソート済の末尾の要素より大きければ挿入不要(そのままでOK)
                //ex)array[0] = 9とtmp = 4(array[1])をCompareToで比較すると
                //   array[0]のほうが大きいため戻り値が1になるので、条件を満たす
                if(array[i - 1].CompareTo(tmp) > 0)
                {
                    //挿入が必要な場合、その位置(j)を決定する
                    //ex)jにiの値(1)をセットする
                    int j = i;

                    //do while文:whileの条件の間、doをループで実行する
                    //必ず一回は実行される
                    do
                    {
                        //挿入するために配列の値をずらしていく
                        //→もともと入っていたarray[j]の値は消滅し、array[j - 1]がセットされる
                        //→array[j - 1]が左にシフトしてくるイメージ
                        //ex)array[1](4)にarray[0](9)の値をセット
                        //   9 4 0 4 9 6 3 2 0 3 → 9 9 0 4 9 6 3 2 0 3 ※4は退避中
                        //                            ^
                        array[j] = array[j - 1];
                        //jをデクリメントし、条件を満たせばもう一度シフトを実行する
                        j--;
                    }
                    //jが1以上であること(0は整列済とみなしているので該当しない) かつ
                    //挿入対象データ(tmp)とその一つ前のデータ(array([j - 1]))を比較し、後者が大きいこと
                    //ex)array[j - 1] = 9、tmp = 4なので、条件を満たす
                    while (j > 0 && array[j - 1].CompareTo(tmp) > 0);

                    //決定した位置に退避していた値を代入
                    //9 9 0 4 9 6 3 2 0 3 → 4 9 0 4 9 6 3 2 0 3
                    //                       ^
                    array[j] = tmp;
                }
            }
        }
    }
}
