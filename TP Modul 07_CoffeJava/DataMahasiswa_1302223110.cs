using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class DataMahasiswa_1302223110
    {
        //nim: 1302223110

        public namaMahasiswa nama{ get; set; }
        public string Nim { get; set; }
        public string Fakultas { get; set; }

        public DataMahasiswa_1302223110()
        {
            nama = new namaMahasiswa();
        }

        public class namaMahasiswa
        {
            public string depan;
            public string belakang;
            public override string ToString()
            {
                return $"{depan}  {belakang}";
            }
        }
        
        public void ReadJSON()
        {
            string jsonFilePath = File.ReadAllText(@"D:\\Kuliah\\Tugas\\MATKUL\\Semester 4\\Konstruksi Perangkat Lunak\\TUBES\\TP Modul 07_CoffeJava\\tp7_1_1302223110.json");
            DataMahasiswa_1302223110 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa_1302223110>(jsonFilePath);

            this.nama= mahasiswa.nama;
            this.Nim = mahasiswa.Nim;
            this.Fakultas = mahasiswa.Fakultas;
               
        }
    }
}
