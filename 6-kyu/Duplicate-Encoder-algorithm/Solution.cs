public class Kata
{
  public static string DuplicateEncode(string word)
  {
    word = word.ToLower();
    string result = "";
    for (int i = 0; i < word.Length; i++){
      bool duplicate = false;
      for(int j = 0; j < word.Length; j++){
        if (i != j && word[i] == word[j]) { duplicate = true; }}
        if (duplicate == true){
          result += ")";
        }
        else {
          result += "(";
        }
        }
    return result;
      }
    
    }
    

