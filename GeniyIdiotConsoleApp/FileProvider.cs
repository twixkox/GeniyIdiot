using System.Text;

namespace GeniyIdiotConsoleApp
{
    public static class FileProvider
    {
        public static string Read(string fileName)
        {
            
            using (var reader = new StreamReader(fileName, true))
            {
                return reader.ReadToEnd();
            }
        }
        public static void Append(string userAllInfo, string fileName)
        {
            using (var writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(userAllInfo);
            }
        }

        public static void Replace(string userAllInfo, string fileName)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine(userAllInfo);
            }
        }

       
        public static void Clear(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }

        public static void Delete(string fileName)
        {
            File.Delete(fileName);
        }
    }
}

