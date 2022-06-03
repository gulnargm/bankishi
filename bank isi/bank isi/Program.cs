using System;

namespace bank_isi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal umumiemekhaqqi;
            string aileveziyyeti;
            int usaqsayi;
            decimal umumigrossemekhaqqi;
            int ailemuavineti = 0;
            int usaqpulu = 0;
            decimal gelirvergiderecesi = 0;
            decimal gelirvergisimebleqi = 0;
            Console.WriteLine("XOŞ GELMİŞSİNİZ");
            Console.WriteLine("Zehmet olmasa emek haqqini daxil edin:");
            umumiemekhaqqi = Convert.ToDecimal(Console.ReadLine());
            umumigrossemekhaqqi = umumiemekhaqqi;
            Console.WriteLine($"Umumi emek haqqi: { umumiemekhaqqi} AZN");
            Console.WriteLine("Zehmet olmasa aile veziyyetini daxil edin: ");
            aileveziyyeti = Console.ReadLine();
            if (aileveziyyeti == "evli")
            {
                ailemuavineti = 50;
                umumigrossemekhaqqi = umumigrossemekhaqqi + ailemuavineti;
            }
            string cavab;
            if (aileveziyyeti == "evli" || aileveziyyeti == "dul")
            {
                Console.WriteLine("usaqiniz varmi? :he ve ya yox ");
                cavab = Console.ReadLine();
                if (cavab == "he")
                {
                    Console.Write("Zehmet olmasa usaqlarin sayini daxil edin: ");
                    usaqsayi = Convert.ToInt32(Console.ReadLine());
                    switch (usaqsayi)
                    {
                        case 1:
                            usaqpulu = usaqpulu + 30;

                            break;
                        case 2:
                            usaqpulu = usaqpulu + 55;
                            break;
                        case 3:
                            usaqpulu = usaqpulu + 75;
                            break;
                        default:
                            int a = usaqsayi - 3;
                            usaqpulu = usaqpulu + 75 + (15 * a);
                            break;
                    }
                    umumigrossemekhaqqi = umumigrossemekhaqqi + usaqpulu;
                }
            }
            if (umumiemekhaqqi <= 1000)
            {
             gelirvergiderecesi = gelirvergiderecesi + 15;
            }
            else if (umumiemekhaqqi <= 2000 && umumiemekhaqqi > 1000)
            {
                gelirvergiderecesi = gelirvergiderecesi + 20;
            }
            else if (umumiemekhaqqi <= 3000 && umumiemekhaqqi > 2000)
            {
                gelirvergiderecesi = gelirvergiderecesi + 25;
            }
            else
            {
                gelirvergiderecesi = gelirvergiderecesi + 30;
            }
            Console.WriteLine("Elillik statusunuz varmi?: he ya da yox");
            cavab = Console.ReadLine().ToLower();
            if (cavab=="he")
            {
                gelirvergiderecesi = gelirvergiderecesi * 50 / 100;
            }
            gelirvergisimebleqi = umumigrossemekhaqqi * gelirvergiderecesi / 100;
            decimal xalisemekhaqqi = umumigrossemekhaqqi - gelirvergisimebleqi;
            Console.WriteLine($"Verilecek Aile Muavineti : {ailemuavineti} manat");
            Console.WriteLine($"Verilecek Usaq Pulu : {usaqpulu} manat");
            Console.WriteLine($"Gelir Vergisi Derecesi: {gelirvergiderecesi}");
            Console.WriteLine($"Gelir Vergisi Meblegi: {gelirvergisimebleqi.ToString("0.00")} manat");
            Console.WriteLine($"Umumi Emek Haqqi: {umumigrossemekhaqqi} manat");
            Console.WriteLine($"Xalis emek haqqi: {xalisemekhaqqi.ToString("0.00")} manat");

            int[] pulvahidi = { 200, 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < pulvahidi.Length; i++)
            {
                int puleskinazi = Convert.ToInt32(Math.Floor(xalisemekhaqqi / pulvahidi[i]));
                if (puleskinazi !=0)
                {
                    Console.WriteLine($"{pulvahidi[i]} pul vahidinden {puleskinazi} eded cixarilacaq") ;
                }
                xalisemekhaqqi = xalisemekhaqqi - (pulvahidi[i] * puleskinazi);
            }
            Console.WriteLine();
        }
    }
}

