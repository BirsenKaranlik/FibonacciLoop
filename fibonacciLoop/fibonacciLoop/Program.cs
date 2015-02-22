using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace fibonacciLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();// programın sonucu ne kadar sürede bulacağını bilmek için stopwatch nesnesi oluşturuldu.

            Console.WriteLine("Kaçıncı fibonacci sayisini bulalim:");

            int x = Int32.Parse(Console.ReadLine()); // bulunacak olan fibonaççi sayısının girilmesi istendi.

            stopwatch.Start(); // süre başlatıldı

            Console.WriteLine("değer:" + fibonacciLoop(x)); //fibonaççi sayısının değeri ekrana yazıldı.

            stopwatch.Stop(); // süre durduruldu. 

            TimeSpan timespan = stopwatch.Elapsed; // Timespan nesnesi oluşturuldu. Bu nesne süreyi ekrana yazdırabilmek için stopwatch fonksiyonunun elapsed özelliğini kullanarak süre hesaplandı.

            string süre = String.Format("{0}:{1}:{2}.{3}", timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.TotalMilliseconds * 1000000);

            Console.WriteLine("Calisma Suresi:" + süre);// çalısma süresini ekrana yazdırıldı.

            Console.ReadLine();// sürenin ekranda görünmesini  sağlandı.
        }

        public static double fibonacciLoop(int x)
        {
            double n = 0;
            double m = 1;
            
            for (double i = 0; i < x; i++)
            {
                double gecici = n;
                n = m;
                m = gecici + m;
            }
            return n;
        }
    }
}
