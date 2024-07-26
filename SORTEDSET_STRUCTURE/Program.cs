using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections.Generic;

namespace SORTEDSET_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //SORTEDSET CLUSTER OPERATIONS
            var A = new SortedSet<int>() { 1,2,3};
            var B = new SortedSet<int>() { 1,2,5,6,8,9};
            //var A = new SortedSet<int>(rastgele_sayı_üret(100));
            //var B = new SortedSet<int>(rastgele_sayı_üret(100));

            //UNION
            
           // A.UnionWith(B);
            /*Console.WriteLine("A VE B KÜMESİNİN BİRLEŞİMİ");
            foreach (int i in A)
            {
                Console.Write($"{i,-5}");
            }
            Console.WriteLine("\nlistenin eleman sayısı: {0} " ,A.Count);
            */
            //INTERSECT
           /* A.IntersectWith(B);
            Console.WriteLine("A VE B KÜMESİNİN KESİŞİMİ");
            foreach (int i in A)
            {
                Console.Write($"{i,-5}");
            }
            Console.WriteLine("\nlistenin eleman sayısı: {0} ", A.Count);
           */

            //EXCEPT
           /* A.ExceptWith(B);
            Console.WriteLine("\nSADECE A KÜMESİNDE OLAN ELEMANLAR");
            foreach (int i in A)
            {
                Console.Write($"{i,-5}");
            }
            Console.WriteLine("\nlistenin eleman sayısı: {0} ", A.Count);*/

            //SYMETRİC
            A.SymmetricExceptWith(B);
            Console.WriteLine("\nKESİŞİM DIŞINDAKİ ELEMANLAR");
            foreach (int i in A)
            {
                Console.Write($"{i,-5}");
            }
            Console.WriteLine("\nlistenin eleman sayısı: {0} ", A.Count);



            Console.ReadLine();
        }
        static List<int> rastgele_sayı_üret(int n)
        {
            var list=new List<int>();   
            var r =new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
                Console.Write($"{list[i],-5}");
            }
            return list;
        }

        private static void SORTEDSET()
        {
            var sayılar = new List<int>();
            var r = new Random();

            for (int i = 0; i < 100; i++)
            {
                sayılar.Add(r.Next(0, 25));
                Console.Write($"{sayılar[i],-5}");
            }

            Console.WriteLine();
            var benzersiz_sayılar = new SortedSet<int>(sayılar);

            foreach (int sayi in benzersiz_sayılar)
            {
                Console.Write($"{sayi,-5}");
            }

            Console.WriteLine();

            Console.Write("benzersiz sayıların sayısı: {0}", benzersiz_sayılar.Count);

        }

        private static void SORTED_SET()
        {

            //SORTEDSET STRUCTURE
            //DESCRIBING

            var list = new SortedSet<string>();
            list.Add("mehmet");



            if (list.Add("ahmet"))
            {
                Console.WriteLine("ahmet listeye eklenmiştir.");
            }
            else
            {
                Console.WriteLine("ahmet listeye eklenmemiştir.");
            }

            //OR
            Console.WriteLine("{0}", list.Add("hasan") == true ? "hasan listeye eklenmiştir." : "hasan listeye eklenmemiştir.");


            //DELETE
            list.Remove("ahmet");
            Console.WriteLine("ahmet listeden kaldırılmıştır..");
            list.RemoveWhere(i => i == "hasan");
            Console.WriteLine("hasan listeden kaldırılmıştır...");
            //ROAM
            Console.WriteLine("\nİSİMLER\n");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            //NUMBER OF ELEMENTS IN THE LIST
            Console.WriteLine("LİSTEDEKİ ELEMAN SAYISI: {0}", list.Count());
        }
    }
}
