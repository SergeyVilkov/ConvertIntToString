namespace ConvertIntToString
{
    public class Program
    {
        public static void Main()
        {
            var data = new ConvertData();
            var number = 154323;
            var sGender = "М";
            var sCase = "Т";

            var result = data.ConvertToString(number, sGender, sCase);
            Console.WriteLine(result);
        }
    }
}