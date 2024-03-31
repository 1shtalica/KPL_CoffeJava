using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_07_CoffeJava
{
    public class DataMahasiswa_1302223023
    {
        private string code;
        private string name;

        public DataMahasiswa_1302223023() { }

        public void ReadJson()
        {
            string json = File.ReadAllText(@"C:\Users\rinda\OneDrive\Documents\C#\KPL_CoffeJava\TP Modul 07_CoffeJava\tp7_1_1302223023.json");
            dynamic mhs = JsonConvert.DeserializeObject(json);
            string namaDe = mhs.Nama.depan;
            string namaBe = mhs.Nama.belakang;
            string Nim = mhs.Nim;
            string Fakultas = mhs.Fakultas;

            Console.WriteLine($"Nama {namaDe} {namaBe} dengan Nim {Nim} dari Fakultas {Fakultas} \n");

        }
    }
}
