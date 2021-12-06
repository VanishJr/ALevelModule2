using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Logger
{
    internal class Configuration
    {
        private Configuration Configuration { get; set; }
        public object KeapFile { get; private set; }
        public object PathLog { get; private set; }

        public readonly string settingsPath = "Configuration.json";
        public void FileService()
        {
            ReadJsonConf();
        }

        private void ReadJsonConf()
        {
            string conf = File.ReadAllText(settingsPath);
            Configuration = JsonSerializer.Deserialize<Configuration>(conf);
            Console.WriteLine($"Name: { Configuration.PathLog}  Age: {Configuration.KeapFile}");
        }
    }
}
