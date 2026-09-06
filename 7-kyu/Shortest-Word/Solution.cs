public class Kata
{
  public static int FindShort(string s)
  {
     int length = int.MaxValue;
     string[] newS = s.Split(' ');
     for (int i = 0; i < newS.Length; i++){
       if (newS[i].Length < length){
         length = newS[i].Length;
     }
  }
    return length;
}}