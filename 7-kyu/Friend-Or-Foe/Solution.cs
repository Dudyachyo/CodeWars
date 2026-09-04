using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    List<string> result = new List<string>();
    foreach (string word in names){
       if (word.Length == 4){
         result.Add(word);
       }
    }
    return result;
  }
}