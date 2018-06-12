using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppTest.laguageTest.DelegateT.Observable;

namespace ConsoleAppTest.laguageTest
{
    class DelegateT
    {
        delegate int NumberChanger(int n);
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //// 创建委托实例
            //NumberChanger nc;
            //NumberChanger nc1 = new NumberChanger(AddNum);
            //NumberChanger nc2 = new NumberChanger(MultNum);
            //nc = nc1;
            //nc += nc2;
            //// 调用多播
            //nc(5);
            //Console.WriteLine("Value of Num: {0}", getNum());
            //Console.ReadKey();

            Observable mObservable = new Observable();
            Observer mObserver = new Observer();
            mObservable.mCallBack += mObserver.doSomeThing;
            mObservable.run();

        }


        public delegate void CallBack(int i);

        public class Observable
        {
            public CallBack mCallBack;

            public Observable()
            {
                //mCallBack = new CallBack();
            }

            public void run()
            {
                for (int i = 0; i < 100; i++)
                {
                    mCallBack(i);
                }
            }

            public class Observer
            {
                public void doSomeThing(int i)
                {
                    Console.WriteLine("打印数字：" + i);
                }

            }
        }
    }
}
