using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1,2,3,4)

            // 1: Değişken Türü
            // 2:Değişken Adı
            // 3:In
            // 4:Liste, Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "ankara", "budapeşte", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 34, 67, 87, 66, 45, 99, 45665, 7899 };

            //foreach (int x in numbers)
            //{
            //  if(x % 2 == 0)
            //    { 
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 34, 67, 87, 66, 45, 99, 45665, 7899 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int>numbers=new List<int>()
            //{
            //    1,2,3,4,5,6,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            //Console.WriteLine("****** C# Eğitim Kampı Sınav Uygulaması ******");
            //Console.Write("---------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sınıftaki öğrenci sayısını kullanıcıdan alam 
            //Console.WriteLine("---------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentcount = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");

            //string[]studentnames=new string[studentcount];
            //double[]studendexamAvg = new double[studentcount];

            //for(int i = 0; i < studentcount; i++)
            //{
            //    Console.Write($"{i + 1}.Öğrencinin İsmini Giriniz: ");
            //    studentnames[i] = Console.ReadLine();

            //    double totalexamresult = 0;

            //    //Her Öğrenci İçin 3 Sınav Notu Girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentnames[i]}.Adlı Öğrencinin {j + 1}.Sınav Notunu Giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalexamresult += value; //NOTLARIN TOPLANDIĞI ALAN 
            //    }
            //    studendexamAvg[i] = totalexamresult/3;
            //    Console.WriteLine();
            //}

            ////Sınav Ortalamaları 
            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.WriteLine($"{studentnames[i]}.Adlı Öğrencinin Ortalaması: {studendexamAvg[i]}");

            //    //Öğrenci oratalamsı ve Geçip Kalma Durumları 
            //    if (studendexamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentnames[i]}.Adlı Öğrenci derten Geçti") ;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentnames[i]}.Adlı Öğrenci derten Kaldı");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("---------------------------------");






            //}


            #endregion

            //Console.Read();




        }
    }
}
