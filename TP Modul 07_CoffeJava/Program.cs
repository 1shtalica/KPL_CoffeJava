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
            Console.ReadLine();
        }
    }
}
