using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQACompetitionTask.Data
{
    public class ReadAndParseJsonFileWithNewtonsoftJson
    {
        private readonly string _sampleJsonFilePath;

        public ReadAndParseJsonFileWithNewtonsoftJson(string sampleJsonFilePath)
        {
            _sampleJsonFilePath = sampleJsonFilePath;
        }

        public List<Teacher> UseUserDefinedObjectWithNewtonsoftJson()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<Teacher> teachers = JsonConvert.DeserializeObject<List<Teacher>>(json);

            return teachers;
        }
    }
   

}
