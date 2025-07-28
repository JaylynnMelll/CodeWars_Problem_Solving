public class Kata
{
  public static string FakeBin(string x)
  {
      // storing the resulting char
      string result = "";
    
      for (int i = 0; i < x.Length; i++)
      {
          int y = 0;
          int number = x[i] - '0';
          
          if (number < 5) y = 0;
          else if (number >= 5) y = 1;
        
          result += y.ToString();
      }
      return result;
  }
}