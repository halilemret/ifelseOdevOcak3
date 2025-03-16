using System;


//Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı
class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir sayı giriniz: ");

        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} bir çift sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} bir tek sayıdır.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girmediniz!");
        }
    }
}

//Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen program

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Lütfen bir sayı giriniz: ");

//        // Kullanıcı girişini al ve sayıya dönüştür
//        if (double.TryParse(Console.ReadLine(), out double sayi))
//        {
//            // Sayının pozitif, negatif veya sıfır olduğunu kontrol et
//            if (sayi > 0)
//            {
//                Console.WriteLine($"{sayi} pozitif bir sayıdır.");
//            }
//            else if (sayi < 0)
//            {
//                Console.WriteLine($"{sayi} negatif bir sayıdır.");
//            }
//            else
//            {
//                Console.WriteLine("Girdiğiniz sayı sıfırdır.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Geçerli bir sayı girmediniz!");
//        }
//    }
//}