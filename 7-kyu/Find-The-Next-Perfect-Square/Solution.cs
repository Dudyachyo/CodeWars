using System; 
public class Kata
{
  public static long FindNextSquare(long num)
  {
    long root = (long)Math.Sqrt(num);
    return root * root == num ? (long)((root + 1) * (root + 1)) : -1;
  }
}