using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rehber
    {
        public string isim { get; set; }
        public int no { get; set; }
    }

    class allfunc
    {
        List<rehber> telephone = new List<rehber>();


        public void addlist(string x, int y)
        {
            telephone.Add(new rehber { isim = x, no = y });

        }


        public void newnumber()
        {
            string isim = "";
            int numara = 0;
            Console.Write("Lütfen isim giriniz             : ");
            isim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            numara = Convert.ToInt32(Console.ReadLine());
            addlist(isim, numara);
        }


        public void deletenumber()

        {
            string isim = "";
            bool contiuneAnswer = true;
            while (contiuneAnswer == true)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                isim = Console.ReadLine();
                rehber kisi = telephone.Find(x => x.isim.Contains(isim));
                if (kisi == null)
                {
                    int answer = 0;
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            contiuneAnswer = false;
                            break;
                        case 2:
                            break;
                    }

                }
                if (kisi != null)
                {
                    Console.WriteLine(isim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string deleteanswer = Console.ReadLine();
                    if (deleteanswer == "y")
                    {
                        telephone.Remove(kisi);
                        Console.WriteLine("Başarı ile Güncellendi");
                        contiuneAnswer = false;
                    }
                }
            }

        }

        public void updatenumber()
        {
            bool contiuneAnswer = true;
            string isim = "";
            while (contiuneAnswer == true)
            {
                Console.Write(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                isim = Console.ReadLine();
                rehber kisi = telephone.Find(x => x.isim.Contains(isim));
                if (kisi == null)
                {
                    int answer = 0;
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            contiuneAnswer = false;
                            break;
                        case 2:
                            break;
                    }

                }
                if (kisi != null)
                {
                    Console.Write(isim + " isimli kişinin yeni numarasını giriniz : ");
                    int newnumber = Convert.ToInt32(Console.ReadLine());



                    kisi.no = newnumber;
                    contiuneAnswer = false;

                }
            }








        }

        public void listelerehber()
        {
            foreach (var item in telephone)
            {

                Console.WriteLine("isim: " + item.isim);
                Console.WriteLine("Telefon Numarası: " + item.no);
            }
        }

        public void kisibul()
        {

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string type = Console.ReadLine();
            if (type == "1")
            {
                Console.WriteLine("Lütfen bulmak istediğiniz isim giriniz : ");
                string isim = Console.ReadLine();
                rehber kisiisim = telephone.Find(x => x.isim.Contains(isim));
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                Console.WriteLine("isim: " + kisiisim.isim);
                Console.WriteLine("Telefon Numarası: " + kisiisim.no);

            }
            else
            {
                Console.WriteLine("Lütfen bulmak istediğiniz no'yu giriniz : ");
                int number = Convert.ToInt32(Console.ReadLine());
                rehber kisino = telephone.Find(x => x.no.Equals(number));
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                Console.WriteLine("isim: " + kisino.isim);
                Console.WriteLine("Telefon Numarası: " + kisino.no);
            }

        }


    }

}
