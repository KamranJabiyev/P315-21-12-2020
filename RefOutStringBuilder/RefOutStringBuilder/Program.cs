using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ref,Out
            //int a = 5;
            //ChangeNumber(a);
            //Console.WriteLine($"a={a}");
            //int[] arr = { 10, 20, 30 };
            //ChangeIndex(arr);
            //Console.WriteLine($"arr[0]={arr[0]}");

            //Ref - must be initialized(assigned),in method override optional
            //int x = 5;
            //ChangeNumRef(ref x);
            //Console.WriteLine($"x={x}");

            //Out - initialized(assigned) optional,in method must be override
            //int a;
            //ChangeNumOut(out a);
            //Console.WriteLine($"a={a}");
            #endregion

            #region Array,String methods
            #region Array
            //int[] arr = new int[100];
            //arr[0] = 1;
            //Array.Resize(ref arr, 101);
            //arr[100] = 5;
            //Console.WriteLine(arr[100]);
            //Console.WriteLine(arr.Length);
            //string[] arrStr = { "Mehemmedeli", "Fikret", "Kenan" };
            //bool exist=arrStr.Contains("kenan");
            //Console.WriteLine(exist);
            //Array.Reverse(arrStr);
            //Array.Clear(arrStr,1,1);
            //foreach (var item in arrStr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrStr.Length);
            //string str=String.Join("-", arrStr);
            //Console.WriteLine(str);
            //int[] arr = { 1, 5, 4, 3, 2 };
            //double avg=arr.Average();
            //Console.WriteLine(avg);
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region String
            //string word = "Hello World"; //{'H','e','l','l','o'...}
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            //Console.WriteLine(word[0]);
            //Console.WriteLine(word.Trim().Length);
            //Console.WriteLine(word.ToUpper().Contains("hel".ToUpper()));
            //string[] arr = word.Split('o');
            //Console.WriteLine(arr[2]);
            #endregion
            #endregion

            #region StringBuilder
            //string[] arr = { "Fikret", "Cavid", "Kenan" };
            //Console.WriteLine(CustomJoin(arr, '-'));
            //StringBuilder builder = new StringBuilder();
            //builder.Append("Hello");

            //builder.Insert(2, "a");
            //builder.Clear();
            //builder.Remove(2,2);
            //builder.Replace("ll","aa");
            //Console.WriteLine(builder);
            #endregion

            #region Homework
            //1.ReverseWordInsen(string sentence) Mes: Input-"Salam P315 Qrupu", Output: "malaS 513P upurQ"
            //Split -allow

            //2.Array Sort metodu - CustomSort(int[] arr) Input:{3,1,2} Output:{1,2,3}
            #endregion
        }

        #region StringBuilder
        //public  static string CustomJoin(string[] arr,char simbol) //{"Fikret","Cavid","Kenan"} - output:"Fikret-Cavid-Kenan"
        //{
        //    string result = arr[0];
        //    //foreach (string word in arr)
        //    //{
        //    //    if(word!=arr[0])
        //    //        result += simbol;
        //    //    result += word;
        //    //}
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        result += simbol;
        //        result += arr[i];
        //    }
        //    return result;
        //}

        public static StringBuilder CustomJoin(string[] arr, char simbol) //{"Fikret","Cavid","Kenan"} - output:"Fikret-Cavid-Kenan"
        {
            StringBuilder result = new StringBuilder(arr[0]);
            //foreach (string word in arr)
            //{
            //    if(word!=arr[0])
            //        result += simbol;
            //    result += word;
            //}
            for (int i = 1; i < arr.Length; i++)
            {
                result.Append(simbol);
                result.Append(arr[i]);
            }
            return result;
        }
        #endregion

        #region Ref,Out
        public static void ChangeNumRef(ref int a)
        {
            a = 10;
            Console.WriteLine($"in method a={a}");
        }

        public static void ChangeNumOut(out int a)
        {
            a = 30;
            Console.WriteLine($"in method a={a}");
        }

        //static public void ChangeNumber(int a)
        //{
        //    a = 10;
        //    Console.WriteLine($"In Method: {a}");
        //}

        //static public void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 1000;
        //    Console.WriteLine($"in method: {arr[0]}");
        //}
        #endregion
    }
}
