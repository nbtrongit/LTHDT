using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruTamGiac:ILuuTruTamGiac
    {
        public TamGiac Doc()
        {
            StreamReader file = new StreamReader("./wwwroot/files/tamgiac.json");
            string json = file.ReadToEnd();
            file.Close();
            return JsonConvert.DeserializeObject<TamGiac>(json);
        }
        public void Luu(TamGiac t)
        {
            string json = JsonConvert.SerializeObject(t);
            StreamWriter file = new StreamWriter("./wwwroot/files/tamgiac.json");
            file.Write(json);
            file.Close();
        }
    }
}
