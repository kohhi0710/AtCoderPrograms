using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace AtCoderTest._01_GoTo水色
{
    class _009_D___星座探し
    {
        static void solve()
        {
            //探したい星座を構成する星の個数m
            int m = int.Parse(ReadLine());

            int[,] seiza = new int[m, 2];

            //mの数だけ読み取り
            //探したい星座を構成するm個の星のx,y座標を取り込む
            for(int i = 0; i < m; i++)
            {
                int[] x = ReadLine().Split().Select(int.Parse).ToArray();
                //変数seizaに探したい星座の値を保持
                seiza[i, 0] = x[0];
                seiza[i, 1] = x[1];
            }

            //写真に写っている星n個
            int n = int.Parse(ReadLine());
            //二次元変数pictureを設定　写真の星の数×2要素
            int[,] picture = new int[n, 2];

            //seizaに格納した最初の座標をもとに全探索する
            //

            //写真の星の数だけループ
            for(int i = 0; i < n; i++)
            {
                //平行移動量を格納する変数
                //x座標の平行移動量(seizaの第一要素 - pictureの座標)
                //y座標の平行移動量(seizaの第一要素 - pictureの座標)
                int[] sa = new int[] { seiza[0, 0] - picture[i, 0], seiza[0, 1] - picture[i, 1] };
                bool found = true;

                //探したい星の数ループ　＆　foundがtrueの間
                for(int j = 1; j < m && found; j++)
                {
                    found = false;

                    //写真の星の数ループ
                    for(int k = 0; k < n; k++)
                    {
                        //探したい星と写真の星を順番に全探索
                        //探したい星の座標(seiza)の座標が、写真の座標(picture) + 平行移動量(sa)の時
                        if ( 
                             seiza[j,0] == picture[k,0] + sa[0] &&
                             seiza[j,1] == picture[k,1] + sa[1]
                           )
                        {
                            //foundをtrueにして答えを出力
                            found = true;
                        }
                    }

                    if(found == true)
                    {
                        WriteLine(-sa[0] + " " + -sa[1]);
                    }
                }
            }
        }
    }
}
