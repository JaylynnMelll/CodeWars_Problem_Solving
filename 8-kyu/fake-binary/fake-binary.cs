using System.Text;
​
public class Kata
{
  public static string FakeBin(string x)
  {
      // A stringbuilder declaration to store the result
      StringBuilder result = new StringBuilder(x.Length);
    
      // loop through each char in x and set the conditions accrodingly
      foreach ( char c in x ) result.Append(c < '5' ? '0' : '1');
    
      return result.ToString();
  }
}