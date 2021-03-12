using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Console;
using static System.Math;

namespace AtCoderTest.CSharp_Training
{
    class Dictionary型
    {
        static void solve()
        {
            //Dictionaryの宣言
            Dictionary<string, string> dic = new Dictionary<string, string>();

            Dictionary<string, string> dic_const = new Dictionary<string, string>()
            {
                {"key0","value0"},
                {"key1","value1"}
            };

            //要素の追加
            dic_const.Add("key2", "value2");
            dic_const.Add("key3", "value3");

            //要素の取り出し
            WriteLine(dic_const["key0"]); //value0

            //要素の列挙
            //foreachで要素のみ指定する
            foreach (string value in dic_const.Values)
            {
                WriteLine(value);
            }

            //キーと要素の列挙
            //KeyValuePair型の変数にforeachで取り出した辞書型のオブジェクトを入れる
            foreach (KeyValuePair<string, string> pair in dic_const)
            {
                WriteLine(pair.Key + " : " + pair.Value);
            }

            //要素数
            WriteLine(dic_const.Count);

            //要素列挙の順番
            Dictionary<string, string> temp = new Dictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                temp.Add("Key" + i.ToString(),
                         "Value" + i.ToString());
            }
            foreach (KeyValuePair<string, string> pair in temp)
            {
                WriteLine(pair.Key + " : " + pair.Value);
            }

            //要素の削除
            dic_const.Remove("key0");


            ReadLine();

        }

    }
}
