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
    internal class DataMahasiswa_1302223027
    {
        public NamaLengkap nama {  get; set; }
        public string nim {  get; set; }
        public string fakultas { get; set; }

        public DataMahasiswa_1302223027() 
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
            string jsonContent = File.ReadAllText("D:\\Tugas pendahuluan\\KPL\\PROJECT\\KPL_CoffeJava\\tp7_1_1302223027.json");
            DataMahasiswa_1302223027 data = JsonConvert.DeserializeObject<DataMahasiswa_1302223027>(jsonContent);
            this.nama = data.nama;
            this.nim = data.nim;
            this.fakultas = data.fakultas;
        }

    }

    

   
}
