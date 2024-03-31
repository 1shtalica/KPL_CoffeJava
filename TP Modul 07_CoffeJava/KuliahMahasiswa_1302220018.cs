using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class KuliahMahasiswa_1302220018
    {
        public List<MataKuliah_1302220018> courses { get; set; }

        public KuliahMahasiswa_1302220018()
        {
            courses = new List<MataKuliah_1302220018>();
        }

        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("D:\\Tugas\\Tugas Kuliah\\Semester 4\\KPL\\kelompok\\KPL_CoffeJava\\TP Modul 07_CoffeJava\\tp7_2_1302220018.json");
            KuliahMahasiswa_1302220018 data = JsonConvert.DeserializeObject<KuliahMahasiswa_1302220018>(jsonContent);
            foreach (var course in data.courses)
            {
                courses.Add(course);
            }
        }
    }

    public class MataKuliah_1302220018
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
