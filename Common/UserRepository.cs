using Newtonsoft.Json;

namespace Game2048App.Common
{
    public class UserRepository
    {
        private static FileProvider fileProvider = new FileProvider();

        public static void AppendUserResult(User user)
        {
            var userResult = GetUserResults();

            userResult.Add(user);

            Save(userResult);
        }

        public static List<User> GetUserResults()
        {
            if (!FileProvider.Exists(fileProvider.NameFileResultGame))
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetValue(fileProvider.NameFileResultGame);

            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);

            return userResults;
        }

        public static void Save(List<User> userResalts)
        {
            var jsonData = JsonConvert.SerializeObject(userResalts, Formatting.Indented);

            FileProvider.Replace(fileProvider.Path, fileProvider.NameFileResultGame, jsonData);
        }
    }
}
