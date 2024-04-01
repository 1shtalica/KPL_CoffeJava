using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class KuliahMahasiswa1302223110
    {
        public Course[] courses { get; set; }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void ReadJSON() 
        {
            string jsonFilePath = File.ReadAllText(@"D:\\Kuliah\\Tugas\\MATKUL\\Semester 4\\Konstruksi Perangkat Lunak\\TUBES\\TP Modul 07_CoffeJava\\tp7_2_1302223110.json");
            KuliahMahasiswa1302223110 matkul = JsonConvert.DeserializeObject<KuliahMahasiswa1302223110>(jsonFilePath);

            courses = matkul.courses;

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine($"MK {i + 1} {courses[i].code} - {courses[i].name}");
            }
        }
    }
}
