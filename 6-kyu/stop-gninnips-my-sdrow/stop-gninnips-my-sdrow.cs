using System.Collections.Generic;
using System.Linq;
using System;
​
public class Kata
{
  public static string SpinWords(string sentence)
  {
      // 01) Split the sentence into words
      string[] words = sentence.Trim(' ').Split(' ');
      string[] result = new string[words.Length];
    
      // 02) loop through each words (foreach)
      int i = 0;
      foreach (string word in words)
      {
          int count = 0;
        
          foreach (char letter in word)
          {
              count++;
          }
        
          // 03) count each char in a word and if it's longer than five then reverse the word
          // 04) Store the processed words
          if (count >= 5) result[i] = WordReverser(word);
          else result[i] = word;
          
          i++;
      }
    
      // 05) join them all together and return the result
      return string.Join(" ", result);
  }
  
  public static string WordReverser(string word)
  {
      char[] container = new char[word.Length];
    
      int j = 0;
      for (int i = word.Length - 1; i >= 0; i--)
      {
          container[j] = word[i];
          j++;
      }
           
      string reversed = new string(container);
      return reversed;
  }
}