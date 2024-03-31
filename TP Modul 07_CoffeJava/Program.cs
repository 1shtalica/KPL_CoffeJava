using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_07_CoffeJava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KuliahMahasiswa_1302220018 matakuliah = new KuliahMahasiswa_1302220018();
            matakuliah.ReadJSON();

            Console.WriteLine();
            Console.WriteLine("daftar mata kuliah");

            for (int i = 0; i < matakuliah.courses.Count; i++)
            {
                Console.WriteLine($"Code: {matakuliah.courses[i].code}");
                Console.WriteLine($"Mata Kuliah: {matakuliah.courses[i].name}");
            }

            Console.ReadLine();
        }
    }
}
