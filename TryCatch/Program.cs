using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
            }
            catch (Exception ex)
            {
                
               Console.WriteLine("Hata: "+ex.Message.ToString());

            }
            //finally{}

        try
        {  
            int a=int.Parse(null);
            
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş bir değer girdiniz");
            Console.WriteLine(ex);
           
        }
        }
    }
}