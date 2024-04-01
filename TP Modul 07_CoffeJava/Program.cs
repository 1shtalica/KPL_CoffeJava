<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302223110 adib = new DataMahasiswa_1302223110();
            adib.ReadJSON();

            Console.WriteLine("Nama : " + adib.nama);
            Console.WriteLine("nim: " + adib.Nim);
            Console.WriteLine("Fakultas: " + adib.Fakultas);

            KuliahMahasiswa1302223110 mk = new KuliahMahasiswa1302223110();
            mk.ReadJSON();
        }
    }
}
=======
﻿using System;
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
>>>>>>> 7a5be4432bde733b49943e960e7cd8ec67404903
