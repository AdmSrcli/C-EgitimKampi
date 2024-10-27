using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori Ekleme İşlemi

            //CRUD= Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı:  ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=MA-JGVZR14;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command=new SqlCommand("insert into tblcategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarılı Şekilde eklendi");

            #endregion


            #region Ürün Ekleme İşlemi

            //string produckname;
            //decimal produckPrice;
            //bool ProduckStatus = true;

            //Console.Write("Ürün Adı:  ");
            //produckname = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //produckPrice = decimal.Parse( Console.ReadLine());

            //SqlConnection connection1 = new SqlConnection("Data Source=MA-JGVZR14;initial catalog=EgitimKampiDb;integrated security=true");
            //connection1.Open();
            //SqlCommand command1 = new SqlCommand("insert into tblproduct (productname,productprice,productstatus) values (@p1,@p2,@p3)", connection1);
            //command1.Parameters.AddWithValue("@p1",produckname);
            //command1.Parameters.AddWithValue("@p2", produckPrice);
            //command1.Parameters.AddWithValue("@p3", ProduckStatus);
            //command1.ExecuteNonQuery();
            //Console.WriteLine("Başaşrılı Şekilde Kaydedildi.");


            #endregion


            #region Ürüm Listeleme İşlemi 

            //SqlConnection connection2 = new SqlConnection("Data Source=MA-JGVZR14;initial catalog=EgitimKampiDb;integrated security=true");
            //connection2.Open();

            //SqlDataAdapter da = new SqlDataAdapter("select * from tblproduct", connection2);
            //DataTable dt=new DataTable();
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)

            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //connection2.Close();

            #endregion


            #region Ürün Silme İşlemleri

            //Console.Write("Silmek İstediğiniz ProcutIdyi Giriniz: ");
            //int productId =int.Parse( Console.ReadLine());

            //SqlConnection connection3 = new SqlConnection("Data Source=MA-JGVZR14;initial catalog=EgitimKampiDb;integrated security=true");
            //connection3.Open();

            //SqlCommand com=new  SqlCommand("Delete from tblProduct where ProductId=@p1",connection3);
            //com.Parameters.AddWithValue("@p1", productId);
            //com.ExecuteNonQuery();
            //connection3.Close();

            //Console.WriteLine("Product Silme işlemi yapıldı!");


            #endregion


            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürün Id:  ");
            int productId=int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün Ad: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı:  ");
            decimal productPrice = decimal.Parse(Console.ReadLine());              

            SqlConnection connection4 = new SqlConnection("Data Source=MA-JGVZR14;initial catalog=EgitimKampiDb;integrated security=true");
            connection4.Open();

            SqlCommand com =new SqlCommand ("update tblproduct set productname=@p1,productprice=@P2 WHERE productId=@p3",connection4);
            com.Parameters.AddWithValue("@p1",productName);
            com.Parameters.AddWithValue("@p2",productPrice);
            com.Parameters.AddWithValue("@p3",productId);
            com.ExecuteNonQuery();
            connection4.Close();
          

            Console.Write("Product Başarılı Şekilde Güncellendi");


            #endregion

            Console.Read();
        }
    }
}
