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
            DataMahasiswa_1302223023 data = new DataMahasiswa_1302223023();
            data.ReadJson();

            KuliahMahasiswa_1302223023 matkul = new KuliahMahasiswa_1302223023();
            matkul.ReadJson();
        }
    }
}
