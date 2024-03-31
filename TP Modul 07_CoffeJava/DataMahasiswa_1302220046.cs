using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    public class DataMahasiswa_1302220046
    {
        public class MahasiswaData
        {
            public Nama Nama { get; set; }
            public int Nim { get; set; }
            public string Fakultas { get; set; }
        }

        public class Nama
        {
            public string Depan { get; set; }
            public string Belakang { get; set; }
        }


        public void ReadJSON()
        {
            string jsonData = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\gruppen\\KPL_CoffeJava\\TP Modul 07_CoffeJava\\tp7_1_1302220046.json");
           
            MahasiswaData data = JsonConvert.DeserializeObject<MahasiswaData>(jsonData);

            Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan nim {data.Nim} dari fakultas {data.Fakultas}");

        }
    }
}
