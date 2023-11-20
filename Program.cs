using System;
namespace dateTime_ve_math_siniflari
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Gunun tarihi ve saati
            Console.WriteLine(DateTime.Now.Date); // Gunun tarihi
            Console.WriteLine(DateTime.Now.Day); //Ayin Gunu
            Console.WriteLine(DateTime.Now.Month); //Ay
            Console.WriteLine(DateTime.Now.Year); //Yil
            Console.WriteLine(DateTime.Now.Hour); //Gunun Saati
            Console.WriteLine(DateTime.Now.Minute); //Gunun Dakikasi
            Console.WriteLine(DateTime.Now.Second); //Gunun Saniyesi

            Console.WriteLine(DateTime.Now.DayOfWeek); //Haftanin hangi gunu
            Console.WriteLine(DateTime.Now.DayOfYear); //Yilin hangi günü

            Console.WriteLine(DateTime.Now.ToLongDateString()); //Gunun uzun yazilmis halini getirir
            Console.WriteLine(DateTime.Now.ToShortDateString()); //Gunun kisa yazilmis halini getirir
            Console.WriteLine(DateTime.Now.ToShortTimeString());//Saatin uzun yazilmis halini getirir 
            Console.WriteLine(DateTime.Now.ToShortTimeString());//Saatin kisa yazilmis halini getirir

            Console.WriteLine(DateTime.Now.AddDays(2)); //tarihe 2 gun ekle
            Console.WriteLine(DateTime.Now.AddHours(3)); // zamana 3 saat ekle
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // zamana 30 saniye ekle
            Console.WriteLine(DateTime.Now.AddMonths(5)); //tarihe 3 ay ekler
            Console.WriteLine(DateTime.Now.AddYears(10)); // tarihe 3 sene ekler
            Console.WriteLine(DateTime.Now.AddMilliseconds(50)); // zamana 50 milisaniye ekler

            // DateTime format
            Console.WriteLine(DateTime.Now.ToString("dd")); //ınt karsiligi olan gunu getirir
            Console.WriteLine(DateTime.Now.ToString("ddd")); //string karsili olan gunun ilk 3 karakterini getirir
            Console.WriteLine(DateTime.Now.ToString("dddd")); //string karsiligi olan tam gunu getirir

            Console.WriteLine(DateTime.Now.ToString("MM")); //ınt karsiligi olan ayi getirir
            Console.WriteLine(DateTime.Now.ToString("MMM")); //string karsiligi olan ayin ilk 3 karakterini getirir
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//string karsiligi olan tam ayi getirir

            Console.WriteLine(DateTime.Now.ToString("yy")); //yilin son iki karakterini getirir
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //yilin tamamini getirir

            Console.WriteLine("*******");

            //Math kutuphanesi
            Console.WriteLine(Math.Abs(-25)); // 25 (mutlak deger)
            Console.WriteLine(Math.Sin(10)); // sinus karsiligi
            Console.WriteLine(Math.Cos(10)); // Cosinus karsiligi
            Console.WriteLine(Math.Tan(10)); // Tanjant karsiligi

            Console.WriteLine(Math.Ceiling(22.3)); // 22.3'den en buyuk tam sayiyi getirir 
            Console.WriteLine(Math.Round(22.3)); // yuvarlama islemi yapar
            Console.WriteLine(Math.Floor(22.7)); // 22.7'den en kucuk tam sayiyiyi getirir

            Console.WriteLine(Math.Max(2, 6)); //iki sayinin en yükseğini gösterir
            Console.WriteLine(Math.Min(2, 6)); //iki sayinin en dusugunu gösterir

            Console.WriteLine(Math.Pow(3, 4)); // 3 uzeri 4'u verir.
            Console.WriteLine(Math.Sqrt(9)); //Karekok alir
            Console.WriteLine(Math.Log(9)); //9'un e tabaninda ki logaritma karsigini verir
            Console.WriteLine(Math.Exp(3)); //e uzeri 3'u verir
            Console.WriteLine(Math.Log10(10)); //10 sayisinin logaritma 10 tabanindaki karsiligini verir
        }
    }
}