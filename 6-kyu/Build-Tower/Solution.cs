public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string [] tower = new string[nFloors];
    
    for (int i = 0; i < nFloors; i++){
      int spacesCount = nFloors - 1 - i;
      int starsCount = (i * 2) + 1;
      
      string spaces = new string(' ', spacesCount);
      string stars = new string ('*', starsCount);
      
      tower[i] = spaces + stars + spaces;
    }
    return tower;
  }
}