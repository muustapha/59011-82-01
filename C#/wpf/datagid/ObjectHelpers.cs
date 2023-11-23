using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    public class ObjectsHelpers
    {
        public bool Log(string path, string contenu)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{DateTime.Now}: {contenu}");
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}