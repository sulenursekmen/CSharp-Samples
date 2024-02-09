using System;
using System.Collections.Generic;


namespace WorkAround
{
    // Ctrl K + D ile kodu düzelt
    public class Program
    {
        static void Main(string[] args)
        {
            
                 
            //Variables();

            Citizen citizen1 = new Citizen();
            citizen1.Name = "";
            citizen1.Lastname = "";

            int result = Topla(3, 5);

            SelamVer(isim: "Sule");
            SelamVer();


            //Arrays 

            string stu1 = "Sule";
            string stu2 = "Sude";
            string stu3 = "Sıla";

            string[] stus = new string[3];

            stus[0] = "Sule";
            stus[1] = "Hatice";
            stus[2] = "Melike";

            for (int i = 0; i < stus.Length; i++)
            {
                Console.WriteLine(stus[i]);
            }


            string[] city1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] city2 = new[] { "Bursa", "Kırşehir", "Diyarbakır" };

            city2 = city1;

            city1[0] = "Adana";
            Console.WriteLine(city2[0]);

            for (int i = 0; i < city2.Length; i++)
            {
                Console.WriteLine(city2[i]);
            }


            for (int i = 0; i < city1.Length; i++)
            {
                Console.WriteLine(city1[i]);
            }

            // int , double , bool deger tiplerdir
            // string ref tiptir deger tip gibi calisir


            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;

            sayi1 = 30;
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi1);

            foreach (var item in city1)
            {
                Console.WriteLine(item);
            }

            List<string> newCity1 = new List<string> { "Uşak", "Bartın", "Batman" };
            newCity1.Add("Kırşehir");

            foreach (var i in newCity1)
            {
                Console.WriteLine(i);

            }

            //PttManager eklenecek

            Console.ReadLine();
        }
        // Edit > Advanced > Word Wrap 
        //  kodu seçin ve sonra Ctrl + . (nokta) tuşlarına basarak refactor seçeneklerini görmek için "Quick Actions and Refactorings" (Hızlı İşlemler ve Refaktörler) penceresini aç ya da ctrl R M 
        private static void Variables()
        {
            // int
            int number = 10;
            Console.WriteLine(number);

            // float
            float pi = 3.14f;
            Console.WriteLine(pi);

            // double
            double value = 123.456;
            Console.WriteLine(value);

            // bool
            bool isTrue = true;
            Console.WriteLine(isTrue);

            // char
            char letter = 'A';
            Console.WriteLine(letter);

            // string
            string message = "Hello";
            Console.WriteLine(message);

            // DateTime
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]); // İlk elemanı yazdırır

            // List
            List<string> names = new List<string>() { "John", "Doe", "Jane" };
            Console.WriteLine(names[0]); // İlk elemanı yazdırır

            // Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("John", 30);
            ages.Add("Jane", 25);
            Console.WriteLine(ages["John"]); // John'un yaşı
        }

        //void sadece isi yapar
        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        //deger döndürür ve o degeri kullanabilirsin
        static int Topla(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            Console.WriteLine("Sonuc " + result);
            return result;
        }

    }

    // Steak (degiskeni tutar) Heap (yer acar)

    // Garbage Collector cöpe atar bellekten

    // array , class , interface , abstract reference tiptir 

    public class Citizen
    {
        // Pascal Casing ile yazılır.
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int BirthYear { get; set; }
        public long TcNo { get; set; }

    }
}