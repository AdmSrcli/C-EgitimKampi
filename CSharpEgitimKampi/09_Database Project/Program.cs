using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Database_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** C# Veri Tabanlı ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("********************************************************");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz:    ");
            tableNumber= Console.ReadLine();
            Console.WriteLine("********************************************************");

            SqlConnection connection = new SqlConnection("Data Source=MA-JGVZR14;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select*from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            foreach(DataRow row in dt.Rows)
            {
                foreach(var Items in row.ItemArray)
                {
                    Console.Write(Items.ToString());
                }

                Console.WriteLine();
            }


            Console.Read();





        }
    }
}
