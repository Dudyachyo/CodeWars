using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    string word = str.ToLower();
    for(int i = 0; i < word.Length; i++){
      char letter = word[i];
      for(int j = i + 1; j < word.Length; j++){
        if(letter == word[j]) return false;
      }
    }
    return true;
  }
}
