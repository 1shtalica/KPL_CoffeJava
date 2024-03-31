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
            

            DataMahasiswa_1302223027 mahasiswa = new DataMahasiswa_1302223027();
            mahasiswa.ReadJSON();

            Console.WriteLine("Nama: " + mahasiswa.nama);
        
            Console.WriteLine("NIM: " + mahasiswa.nim);
            Console.WriteLine("Fakultas: " + mahasiswa.fakultas);
            


            KuliahMahasiswa_1302223027 matakuliah = new KuliahMahasiswa_1302223027();
            matakuliah.ReadJSON();

            Console.WriteLine();
            Console.WriteLine("daftar mata kuliah");

            for (int i = 0;i < matakuliah.courses.Count;i++)
            {
                Console.WriteLine($"Code: {matakuliah.courses[i].code}");
                Console.WriteLine($"Mata Kuliah: {matakuliah.courses[i].name}");
            }

            Console.ReadLine();
        }
    }
}
