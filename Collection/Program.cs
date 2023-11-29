//System.Collections
//************************
// список элементов
//System.Collections.ArrayList
// System.Collections.Queue
// System.Collections.Stack
// System.Collections.BitArray
//списки пар ключей и значений
// System.Collections.SortedList
//  System.Collections.Hashtable

//*******************
//System.Collections.Specialized

//System.Collections.Specialized.ListDictionary - 
//System.Collections.Specialized.HybridDictionary
//System.Collections.Specialized.CollectionsUtil  -
//System.Collections.Specialized.NameValueCollection -
//System.Collections.Specialized.StringCollection -
//System.Collections.Specialized.StringDictionary -

//1 System.Collections.ArrayList
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //ArrayList arrayList1 = new ArrayList();
            //Console.WriteLine($"Вместимость по умолчанию:{arrayList1.Capacity}{arrayList1.Count}");
            ////2
            //ArrayList arrayList2 = new ArrayList(5);
            //WriteLine($"Вместимость :{arrayList2.Capacity} {arrayList2.Count}");
            //3
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add("word");
            //WriteLine($"Вместимость после добавления одного элемента: { arrayList1.Capacity}");
            ////4
            //arrayList1.Add("letter");
            //WriteLine($"Вместимость после добавления одного элемента: { arrayList1.Capacity}");
            //5
            //ArrayList arrayList1 = new ArrayList();
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.Capacity = 17;
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //6
            //ArrayList arrayList1 = new ArrayList(2);
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.AddRange(new int[] { 1, 2, 3});
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //7

            //ArrayList arrayList1 = new ArrayList(7);
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.AddRange(new int[] { 1, 2, 3 });
            //WriteLine($"Вместимость :{ arrayList1.Capacity}");
            //arrayList1.TrimToSize();
            //WriteLine($"Вместимость уменьшена до реального  количества элементов: { arrayList1.Capacity}");
            //8
            //ArrayList arrayList1 = new ArrayList(new int[] { 1, 2, 3 });
            //WriteLine($"Элемент с индексом 2: { arrayList1[2]} ");
            //9
            //ArrayList arrayList1 = new ArrayList(new string[] { "one", "two", "three", null });
            //WriteLine($"Фактическое количество элементов: { arrayList1.Count}  ");
            //10
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add("one");
            //arrayList1.Add(10);
            //arrayList1.Add(true);
            //WriteLine("Все элементы коллекции:");
            //*10.1
            //foreach (object item in arrayList1)
            //{
            //    WriteLine($"\t{item}");
            //}
            //*10.2
            //foreach (object o in arrayList1)
            //    WriteLine(o.ToString());
            //int i = (int)arrayList1[1];
            //WriteLine($"\t{i}");

            //11
            //ArrayList days = new ArrayList(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday ", "Thursday ", "Friday", "Saturday " });

            //ArrayList only = new ArrayList(days.GetRange(0, 3));
            //foreach (string s in only)
            //WriteLine(s);

            //12
            //ArrayList numbers = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //numbers.Insert(2, 22);
            //foreach (int i in numbers)
            //WriteLine(i);

            //13
            //ArrayList numbers = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //numbers.RemoveAt(2);
            //foreach (int i in numbers)
            //    WriteLine(i);
            //14
            //ArrayList numbers = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //numbers.Sort();
            //foreach (int i in numbers)
            //    WriteLine(i);
            //IndeOf(obj), LastIndexOf(object)





            /////////////////////////////////////////////////////////////////////////////////
            //1.1
            //Stack stack = new Stack();
            ////1.2
            //Stack stack = new Stack(5);
            ////3
            //Write("Метод Push(): \n");
            //stack.Push("one");
            //stack.Push("two");
            //stack.Push("three");
            //foreach (string str in stack)
            //{
            //    WriteLine(str);
            //}
            //4

            //Write("\n\nМетод Pop(): \n");
            //stack.Pop();
            //foreach (string str in stack)
            //{
            //    WriteLine(str);
            //}

            //5
            //string var = (string)stack.Peek(); //peek() allow us to look through our data without deleting it 
            //WriteLine(var);
            //foreach (string str in stack)
            //{
            //    WriteLine(str);
            //}

            //6
            //Stack s = new Stack();
            //s.Push("one");
            //s.Push("two");
            //s.Push("three");
            //WriteLine(s.Contains("ten"));
            //WriteLine(s.Contains("one"));

            //7
            //Stack s = new Stack();
            //s.Push("one");
            //s.Push("two");
            //s.Push("three");
            //WriteLine(s.Count);
            //s.Clear();
            //WriteLine(s.Count);

            //8
            //Write("\nМетод CopyTo():\n ");
            //string[] str = new string[s.Count];
            //s.CopyTo(str, 0);
            //foreach (string item in str)
            //{
            //    WriteLine(item);
            //}

        }
    }
}
