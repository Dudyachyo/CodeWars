public class Kata
{
    public static int Find(int[] integers)
    {
        int oddCount = 0;
      int evenCount = 0;
      for (int i = 0; i < integers.Length; i++){
        if (integers[i] % 2 == 0){
          evenCount++;
        }
        else{
          oddCount++;
        }
      }
      if (evenCount == 1){
        foreach(int number in integers){
          if (number % 2 == 0){
            return number;
          }
        }
      }
      else {
        foreach(int number in integers){
          if(number % 2 != 0){
            return number;
          }
        }
      }
      return 0;
    }
}