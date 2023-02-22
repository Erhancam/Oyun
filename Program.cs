using System;

namespace Oyun
{
     class Program  
    {

        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0,100);
            int i =1;
            
            while(true)
            {
                Console.Write("Tahmin NO:" + i + "Bir sayi giriniz:");
                i++;
                string cevap = Console.ReadLine();
                int cevapsayi = Convert.ToInt32(cevap);
                if(cevapsayi == sayi){
                    Console.WriteLine("Bravo");
                    break;
                }
                
                else if(Math.Abs(cevapsayi-sayi) < 5){
                    Console.WriteLine("Çok Sicak");
                }

               else if(Math.Abs(cevapsayi-sayi) < 10){
                    Console.WriteLine("Sicak");
                }
                
                else if(Math.Abs(cevapsayi-sayi) < 15){
                    Console.WriteLine("Eh iste");
                }
                
                else if(Math.Abs(cevapsayi-sayi) < 20){
                    Console.WriteLine("Soguk");
                }
                
                else
                {
                    Console.WriteLine("cok soguk");
                }



                
            //Console.WriteLine(sayi);
            }
        }
    }
}