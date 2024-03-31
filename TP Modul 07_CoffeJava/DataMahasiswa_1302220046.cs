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
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public int Nim { get; set; }
        public string Fakultas { get; set; }

        public void ReadJSON()
        {
            string jsonData = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\gruppen\\KPL_CoffeJava\\TP Modul 07_CoffeJava\\tp7_1_1302220046.json");

            DataMahasiswa_1302220046 data = JsonConvert.DeserializeObject<DataMahasiswa_1302220046>(jsonData);

            Console.WriteLine($"Nama {data.NamaDepan} {data.NamaBelakang} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
        }
    }
}
