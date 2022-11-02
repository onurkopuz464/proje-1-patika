using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            allfunc func = new allfunc();
            func.addlist("Sinem", 0543546546);
            func.addlist("fatih", 0543546547);
            func.addlist("şükran", 0543546548);
            func.addlist("büşra", 0543546549);
            func.addlist("defne", 0543546540);

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    func.newnumber();
                    break;
                case 2:
                    func.deletenumber();
                    break;
                case 3:
                    func.updatenumber();
                    break;
                case 4:
                    func.listelerehber();
                    break;
                case 5:
                    func.kisibul();
                    break;

            }
            











        }
       
    }
}
