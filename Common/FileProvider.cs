using System.Text;

namespace Common
{
    public class FileProvider
    {
        private const string path = @"Settings";

        private const string nameFileResultGame = @"Settings\ResultGame.json";

        public string Path
        {
            get { return path; }
        }
        public string NameFileResultGame
        {
            get { return nameFileResultGame; }
        }

        public void AppendToFile(string path, string nameFile, string value)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            using(StreamWriter sw = new StreamWriter(nameFile, true, Encoding.Default))
            {
                sw.WriteLine(value);
            }
        }
        public static void Replace(string paht, string nameFile, string value)
        {
            DirectoryInfo directory = new DirectoryInfo(paht);

            if (!directory.Exists)
            {
                directory.Create();
            }

            using (StreamWriter sw = new StreamWriter(nameFile, false, Encoding.Default))
            {
                sw.WriteLine(value);
            }
        }
        public static string GetValue(string nameFile)
        {
            using (StreamReader sr = new StreamReader(nameFile, Encoding.Default))
            {
                string textResult = sr.ReadToEnd();
                return textResult;
            }
        }

        public static bool Exists(string nameFile)
        {
            return File.Exists(nameFile);
        }
        internal static void Clear(string nameFile)
        {
            File.WriteAllText(nameFile, string.Empty);
        }
    }
}
