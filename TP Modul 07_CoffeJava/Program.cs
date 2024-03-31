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

            DataMahasiswa_1302220046 mahasiswa = new DataMahasiswa_1302220046();


            mahasiswa.ReadJSON();

            Console.WriteLine("Nama Depan: " + mahasiswa.NamaDepan);
            Console.WriteLine("Nama Belakang: " + mahasiswa.NamaBelakang);
            Console.WriteLine("NIM: " + mahasiswa.Nim);
            Console.WriteLine("Fakultas: " + mahasiswa.Fakultas);
        }
    }
}
