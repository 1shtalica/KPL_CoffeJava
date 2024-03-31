using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    public class KuliahMahasiswa_1302223023
    {
        private string Nama { get; set; }
        private string Nim { get; set; }
        private string Fakultas { get; set; }

        public KuliahMahasiswa_1302223023 () { }

        public void ReadJson()
        {
            string jsonFile = File.ReadAllText(@"C:\Users\rinda\OneDrive\Documents\C#\KPL_CoffeJava\TP Modul 07_CoffeJava\tp7_2_1302223023.json");
            dynamic matkul = JsonConvert.DeserializeObject(jsonFile);
            Console.WriteLine("Mata Kuliah yang diambil:");
            int i = 1;
            foreach (var item in matkul.courses)
            {
                Console.WriteLine($"MK " + i + " " + item.code + " - " + item.name);
                i++;
            }
        }
    }
}
