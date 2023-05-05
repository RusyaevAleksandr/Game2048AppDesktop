using System.Text;

namespace Game2048App.Common
{
    public class FileProvider
    {
        private string path = @"Settings";

        private string nameFileResultGame = @"Settings\ResultGame.json";

        private string nameFileRulesGame = @"Settings\RulesGame.json";

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string NameFileResultGame
        {
            get { return nameFileResultGame; }
            set { nameFileResultGame = value; }
        }

        public string NameFileRulesGame
        {
            get { return nameFileRulesGame; }
            set { nameFileRulesGame = value; }
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
    }
}
