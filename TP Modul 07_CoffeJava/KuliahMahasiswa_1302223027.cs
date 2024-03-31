using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TP_Modul_07_CoffeJava
{
    internal class KuliahMahasiswa_1302223027
    {
        public List<MataKuliah_1302223027> courses { get; set; }
        public KuliahMahasiswa_1302223027()
        {
            courses = new List<MataKuliah_1302223027>();
        }

        public void ReadJSON()
        {
            string jsonContent = File.ReadAllText("D:\\Tugas pendahuluan\\KPL\\PROJECT\\KPL_CoffeJava\\tp7_2_1302223027.json");
            KuliahMahasiswa_1302223027 data = JsonConvert.DeserializeObject<KuliahMahasiswa_1302223027>(jsonContent);



            for (int i = 0; i < data.courses.Count; i++)
            {
                courses.Add(data.courses[i]);
                

                 
            }

            

            

        }
    }

    public class MataKuliah_1302223027
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
