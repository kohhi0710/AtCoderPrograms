using System;
using System.Collections.Generic;
using System.Text;

//http://ichitcltk.hustle.ne.jp/gudon2/index.php?pageType=file&id=cs004_Nested_class

namespace InnerClass
{
    /// <summary>
    /// 入れ子クラス
    /// </summary>
    class OuterClass
    {
        public class InnerClass
        {
            public void Method()
            {
                Console.WriteLine("内部クラスのメソッドが実行されました。");
            }
        }
    }

    /// <summary>
    /// 実行用テストクラス
    /// </summary>
    class foo
    {
        static void _Main()
        {
            OuterClass.InnerClass innerClass = new OuterClass.InnerClass();
            innerClass.Method();
        }
    }
}

//----------------------------------------------------------------------

namespace InnerClass2
{
    /// <summary>
    /// 入れ子クラス
    /// </summary>
    class OuterClass
    {
        public class InnerClass
        {
            public void Method()
            {
                Console.WriteLine("内部クラスのメソッドが実行されました。");
            }
        }
    }

    /// <summary>
    /// 入れ子クラスを継承
    /// </summary>
    class OuterClassEX : OuterClass { }

    /// <summary>
    /// 実行用テストクラス
    /// </summary>
    class foo
    {
        static void _Main()
        {
            //継承クラスから親クラス内部のクラスにアクセスすることができる
            OuterClass.InnerClass innerClass = new OuterClassEX.InnerClass();
            innerClass.Method();
        }
    }

    //----------------------------------------------------------------------

}
