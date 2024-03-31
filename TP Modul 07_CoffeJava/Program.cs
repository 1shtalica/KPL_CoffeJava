using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP_Modul_07_CoffeJava
{


    internal class Program
    {
        static void Main(string[] args)
        {

            DataMahasiswa_1302220046 dataMahasiswa = new DataMahasiswa_1302220046();
            dataMahasiswa.ReadJSON();


            KuliahMahasiswa_1302220046 matakuliah = new KuliahMahasiswa_1302220046();
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
