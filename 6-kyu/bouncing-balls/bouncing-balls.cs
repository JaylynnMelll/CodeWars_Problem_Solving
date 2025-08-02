using System;
​
public class BouncingBall {
  
  public static int bouncingBall(double h, double bounce, double window) 
  {
      // Exception handling
      if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;
    
      // Initial fall is always visible to mom
      int count = 1;
      double heightAfterBounce = h * bounce;
      
      // repeat until the ball's bounce is not high enough to be seen
      while (heightAfterBounce > window)
      {
          // count two because ball is seen twice, going up and down
          count += 2;
          heightAfterBounce *= bounce;
      }
    
      return count;
  }
}