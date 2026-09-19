using System;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    string s = str.ToLower();
    int[] counts = new int[256];
    foreach (char c in s){
      counts[c]++;
    }
    int duplicates = 0;
    foreach (int count in counts){
      if (count > 1){ duplicates++;}
    }
    return duplicates;
  }
}