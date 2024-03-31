using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class KuliahMahasiswa_1302220046
    {

            public string code { get; set; }
            public string name { get; set; }
        
        public List<KuliahMahasiswa_1302220046> courses { get; set; }
        public KuliahMahasiswa_1302220046()
        {
            courses = new List<KuliahMahasiswa_1302220046>();
        }


        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("C:\\Users\\LENOVO\\Downloads\\skool tugas\\Semester 4\\Konstruksi\\tp\\gruppen\\KPL_CoffeJava\\TP Modul 07_CoffeJava\\tp7_2_1302220046.json");
            KuliahMahasiswa_1302220046 data = JsonConvert.DeserializeObject<KuliahMahasiswa_1302220046>(jsonContent);



            for (int i = 0; i < data.courses.Count; i++)
            {
                courses.Add(data.courses[i]);



            }





        }
    }

 
}