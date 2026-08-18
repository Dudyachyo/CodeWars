public class Kata
{
  public static string Greet(string name, string owner)
  {
    if (name == owner){
      return "Hello boss";
    }
    else {
      return "Hello guest";
    }
// !!! But then I realized that I could make it even simpler by using a ternary operator. Here's the updated code:
    // return name == owner ? "Hello boss" : "Hello guest";
}
} 
