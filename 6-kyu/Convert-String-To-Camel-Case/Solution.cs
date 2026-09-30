using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] newstr = str.Split('-', '_');
    for (int i = 1; i < newstr.Length; i++){
      if (newstr[i].Length > 0)
            {
                newstr[i] = char.ToUpper(newstr[i][0]) + newstr[i].Substring(1);
            }
    }
    return string.Join("", newstr);
  }
}