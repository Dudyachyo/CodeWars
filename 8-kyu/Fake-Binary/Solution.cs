public class Kata
{
    public static string FakeBin(string x)
    {
        string result = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < '5')
            {
                result += "0";
            }
            else
            {
                result += "1";
            }
        }
        return result;
    }
}