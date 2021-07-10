using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using TodayXML.Model;
using TodayXML.Serializer;


namespace TodayXML
{
    public class CurrencyService : ICurrencyService
    {
        private string urlPattern = "https://www.tcmb.gov.tr/kurlar/today.xml";
        private readonly WebClient client;
        private readonly IXmlSerializer serializer;

        public CurrencyService()
        {
            client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            serializer = new XmlSerializer();
        }
        public Task<CurrencyModel[]> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyModel[]> GetToday()
        {
            var url = new Uri(string.Format(urlPattern));
            string startupPath = Environment.CurrentDirectory;
            string data = "";
            string path = startupPath + $"\\wwwroot\\XMLToday\\{DateTime.Today.Day.ToString()}-{DateTime.Today.Month.ToString()}-{DateTime.Today.Year.ToString()}.txt";

            var ItsTime = DateTime.Now.Hour > 9;

            if ((!File.Exists(path) && !Directory.Exists(path)) && ItsTime)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                data = client.DownloadString(url);
                WriteToFile(data, path);
                 
                ClearInFolder(path);


            }

            data = ReadFromFile(@$"{path}");
            var deserialize = serializer.Deserializer<Tarih_Date>(data);
            var result = deserialize.Currency.Select(CurrencyModel.Map).ToArray();

            return Task.FromResult(result);

        }

        private void ClearInFolder(string path)
        {
            string folderPathbuild = "";
            string[] folderPath = path.Split(Path.DirectorySeparatorChar);
            for (int i = 0; i < folderPath.Length - 1; i++)
            {
                folderPathbuild += folderPath[i] + @"\";
            }
            string[] files = Directory.GetFiles(folderPathbuild);
            foreach (string file in files)
            {
                if (file != path)
                {
                    File.Delete(file);
                }
            }
        }

        private static void WriteToFile(string data, string path)
        {
            string dosya_yolu = path;

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(data);


            sw.Flush();

            sw.Close();
            fs.Close();

        }
        public static string ReadFromFile(string path)
        {
            string dosya_yolu = path;

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadToEnd();


            sw.Close();
            fs.Close();

            return yazi;

        }

    }
}
