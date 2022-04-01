using System;

namespace Abstract_class._Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa sayi daxil edin");
            int count = Int32.Parse(Console.ReadLine());
            while (count <= 0)
            {
                Console.WriteLine("Zehmet olmasa sayi duzgun daxil edin");
                count = Int32.Parse(Console.ReadLine());
            }

            Book[] book = new Book[count];

            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine("Kitabin nomresi: ");
                int no = Int32.Parse(Console.ReadLine());
                while (no < 0)
                {
                    Console.WriteLine("Nomreni duzgun daxil edin");
                    no = Int32.Parse(Console.ReadLine());

                }
                Console.WriteLine("Kitabin adi: ");
                string name = Console.ReadLine();
                while (name.Trim() == " " || name.Trim() == "")
                {
                    Console.WriteLine("Adi duzgun daxil edin");
                    name = Console.ReadLine();

                }
                Console.WriteLine("Kitabin qiymeti: ");
                double price = Int32.Parse(Console.ReadLine());
                while (price < 0)
                {
                    Console.WriteLine("Qiymeti duzgun daxil edin");
                    price = Int32.Parse(Console.ReadLine());

                }
                Console.WriteLine("Kitabin janri: ");
                string genre = Console.ReadLine();
                while (genre.Trim() == " " || genre.Trim() == "")
                {
                    Console.WriteLine("Janri duzgun daxil edin");
                    genre = Console.ReadLine();

                }

                book[i] = new Book(no, name, price, genre);

            }



            Console.WriteLine("1.Kitablari qiymete gore filtrle\n2.Butun kitablari goster\n0.Programi bagla");
            int choice = Int32.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("Zehmet olmasa min deyeri daxil edin:");
                int MinPrice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa max deyeri daxil edin:");
                int MaxPrice = Int32.Parse(Console.ReadLine());
                foreach (var item in book)
                {
                    if (item.Price > MinPrice && item.Price < MaxPrice)
                    {
                        Console.WriteLine($"Kitabin nomresi: {item.No}\nKitabin adi: {item.Name}\nKitabin qiymeti: {item.Price}\nKitabin janri: {item.Genre}\n\n");
                    }
                }
            }
            else if (choice == 2)
            {
                foreach (var item in book)
                {
                    Console.WriteLine($"Kitabin nomresi: {item.No}\nKitabin adi: {item.Name}\nKitabin qiymeti: {item.Price}\nKitabin janri: {item.Genre}\n\n");
                }

            }
            else if (choice == 0)
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Menuda daxil edilen sechim yoxdur.");
            }

        }
    }
}
