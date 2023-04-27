namespace Common
{
    public class MainLogicApp
    {
        private static Random random = new Random();

        private static string[] number = new string[] {"2", "2", "2", "4"};        

        public static string ShowRandomNumber()
        {
            var randomNumber = number[random.Next(number.Length)];

            return randomNumber.ToString();
        }
    }
}
