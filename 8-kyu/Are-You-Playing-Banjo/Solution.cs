using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    return name[0] is 'r' or 'R' ? $"{name} plays banjo" : $"{name} does not play banjo";
  }
}