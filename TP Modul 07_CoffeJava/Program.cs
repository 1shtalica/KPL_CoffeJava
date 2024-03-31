using System;
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
