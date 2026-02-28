public static class Kata
{
  public static int Score(int[] dice) 
  {
    int[] count = new int[7];
    foreach(var die in dice)
      count[die]++;

    int score = 0;

    if(count[1] >= 3)
    {
      score += 1000;
      count[1] -= 3;
    }

    for(int i = 2; i < 7; i++)
    {
      if(count[i] >= 3)
      {
        score += i * 100;
        count[i] -= 3;
      }
    }

    score += count[1] * 100;
    score += count[5] * 50;

    return score;
  }
}