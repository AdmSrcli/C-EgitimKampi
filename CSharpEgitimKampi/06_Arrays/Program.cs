using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Dizi Örnekleri=
            //2,4,6,8,
            //sarı,kırmızı,yeşil,pembe
            //Adana,ankara,istanbul,sivas

            // 1.DİZİ SİNTAX YAPISI
            // Değişken Türü [] Dizi Adı= new Değişken Türü [ Eleman Sayısı]

            // Örnek

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int [10];
            //numbers [0] = 30;
            //numbers[1] = 25;
            //numbers[2] = 248;
            //numbers[3] = 456;
            //numbers[8]=850;
            //numbers[9] = 666;
            //Console.WriteLine(numbers[9]);

            //2.DİZİ SİNTAX YAPISI

            //string[] cities = { "Prag", "Roma", "Atina", "İstanbul", "Ankara" };
            //Console.WriteLine(cities[3]);

            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Mavi", "Yeşil", "Pembe", "Mavi", "Turuncu", "Kırmızı" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 6, 15, 48, 55, 98, 65, 70, 53, 300, 600, 900 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'g', 'z', 'x', 'k' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myarray = { 32, 45, 67, 98, 118, 144, 168, 23, 36, 378 }; 

            //int maxnumber=myarray[0];

            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }

            //}
            //Console.WriteLine(maxnumber);

            //string[] persons = { "Ali", "Ahmet", "Büşra", "Yasin", "Çiğdem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 6, 15, 48, 55, 98, 65, 70, 53, 300, 600, 900 };
            /*Array.Sort(numbers); */    // Diziyi Küçükten Büyüğe Sıralamayı Sağlayan Kod
                                         //Array.Reverse(numbers);   //Diziyi yazıldığı Şekli ile Sondan Başa Sıralayan Kod

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion


            #region Dizi Metotlar

            //DİZİ İÇERİSİNDE ARANILAN ELEMANIN KAÇINCI İNDEXTE OLDUĞUNU GÖZTEREN YAPI:
            //string [] customers = { "Ali", "Ayşe", "Mehmet", "Yakup", "Fatih" };
            //int index = Array.IndexOf(customers, "Mehmet");
            //Console.WriteLine(index);

            //int[] numbers = { 16, 27, 34, 76, 9, 45, 23 ,112,1,6,33};
            //Console.WriteLine("En büyük Eleman:"+numbers.Max());
            //Console.WriteLine("En küçük Eleman:" + numbers.Min());




            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.Write($"Lüten {i+1}.Şehri Giriniz: ");
            //     cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] number = { 34, 32, 56, 78, 555, 334, 678, 222, 897, 46, 27, 80 };
            //Console.WriteLine("Çift Sayılar:");
            //Console.WriteLine("");

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Tek Sayılar:");
            //Console.WriteLine("");

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 1)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}




            #endregion


            //Console.Read();    
        }
    }
}
