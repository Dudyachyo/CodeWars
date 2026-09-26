using System;

public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string[] result = phrase.Split(' ');
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i].Length > 0)
            {
                result[i] = char.ToUpper(result[i][0]) + result[i].Substring(1);
            }
        }
        return string.Join(" ", result);
    }
}