using System;

namespace mass
{
    class Check
    {
        static void Main(string[] args)
        {
            string adres = "Москва, Волгоградский пр-т, 26";
            long znkkt = 0472570020000241;
            var dat = DateTime.Now;
            long inn = 9721018628;
            string rnkkt = "РН ККТ 0000000000018780";
            long fn = 9999078900003693;
            string site = "www.nalog.ru";
            string check = "*  КАСОВЫЙ ЧЕК  *";
            string numSmena = "НОМЕР СМЕНЫ ";
            int num = 1;
            string numCheck = "НОМЕР ЧЕКА ЗА СМЕНУ ";
            int cost = 500;
            int volume = 100;
            int finCost = 50000;


            Console.WriteLine("       ООО КАССОПТТОРГ");
            Console.WriteLine("ООО КАССОПТТОРГ");
            Console.WriteLine(adres);
            Console.WriteLine("ЗН ККТ " + znkkt + "  " + "   #0002");
            Console.WriteLine("СИСТ. АДМИН." + " " + dat);
            Console.WriteLine("ПРИХОД" + "            " + "ИНН " + inn);
            Console.WriteLine(rnkkt);
            Console.WriteLine("ФН " + fn);
            Console.WriteLine("САЙТ ФСН   " + "         " + site);
            Console.WriteLine("       " + check);
            Console.WriteLine(numSmena + "                   " + num);
            Console.WriteLine(numCheck + "           " + num);
            Console.WriteLine("                         " + cost + "x" + volume);
            Console.WriteLine(num + "                          " + finCost);
            Console.WriteLine("БЕЗ НАЛОГА 0.00%           =0.00");
            Console.WriteLine("ИТОГ                     = 50000");
            Console.WriteLine(" НАЛИЧНЫМИ              = 100000");
            Console.WriteLine("СДАЧА                    = 50000");
            Console.WriteLine("СНО                          ОСН");
            Console.WriteLine("ФД: 3             ФП: 4106393690");

        }
    }
}
