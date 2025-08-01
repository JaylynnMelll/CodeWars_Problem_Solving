public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hour = 0;
        int min = 0;
        int sec = 0;
      
        int temp = 0;
      
        // Get Seconds
        sec = seconds % 60;
          
        // Get Hours & Minutes
        temp = seconds / 60;
      
        // Hours
        hour = temp / 60;
      
        // Minutes
        min = temp % 60;
      
        return $"{hour:D2}:{min:D2}:{sec:D2}";
    }
}