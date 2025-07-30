public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
      if (smileys.Length == 0) return 0;
    
      int count = 0;
    
      foreach (string smiley in smileys)
      {
          int smileyLength = smiley.Length;
          
          if (smileyLength == 2) count += SmileyFilter_ForTwo(smiley);
            
          if (smileyLength == 3) count += SmileyFilter_ForThree(smiley);
            
          else continue;
      }
    
      return count;
  }
  
  public static int SmileyFilter_ForTwo (string smiley)
  {
      int ifValid = 0;  
    
      bool isValidEyes = false;
      bool isValidMouth = false;
    
      foreach (char s in smiley)
      {
          if (s == ':' || s == ';') isValidEyes = true;
          if (s == 'D' || s == ')') isValidMouth = true;
      }
      
      if (isValidEyes && isValidMouth) ifValid = 1;
    
      return ifValid;
  }
  
  public static int SmileyFilter_ForThree (string smiley)
  {
      int ifValid = 0;  
    
      bool isValidEyes = false;
      bool isValidNose = false;
      bool isValidMouth = false;
    
      foreach (char s in smiley)
      {
          if (s == ':' || s == ';') isValidEyes = true;
          if (s == '-' || s == '~') isValidNose = true;
          if (s == 'D' || s == ')') isValidMouth = true;
      }
    
      if (isValidEyes && isValidNose && isValidMouth) ifValid = 1;
    
      return ifValid;
  }
  
  
}