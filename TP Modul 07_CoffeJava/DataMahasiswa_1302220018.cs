using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class DataMahasiswa_1302220018
    {
        public NamaLengkap nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa_1302220018()
        {
            nama = new NamaLengkap();
        }
        public class NamaLengkap
        {

            public string Depan;
            public string Belakang;
            public override string ToString()
            {
                return $"{Depan} {Belakang}";
            }

        }



        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\kelompok\\KPL_CoffeJava\\TP Modul 07_CoffeJava\\tp7_1_1302220018.json");
            DataMahasiswa_1302220018 data = JsonConvert.DeserializeObject<DataMahasiswa_1302220018>(jsonContent);
            this.nama = data.nama;
            this.nim = data.nim;
            this.fakultas = data.fakultas;
        }

    }




}
