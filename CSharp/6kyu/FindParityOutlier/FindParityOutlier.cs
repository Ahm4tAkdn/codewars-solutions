public class Kata
{
  public static int Find(int[] integers)
  {
    int evenCount = 0;
    int lastEven = 0;
    int lastOdd = 0;

    foreach (int n in integers)
    {
      if (n % 2 == 0)
      {
        evenCount++;
        lastEven = n;
      }
      else
      {
        lastOdd = n;
      }
    }

    return evenCount == 1 ? lastEven : lastOdd;
  }
}