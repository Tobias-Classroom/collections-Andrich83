using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections

{
  public static class CollectionsHelper
  {
    public static List<int> AddRandomNumbersToList(List<int> numbers, int quantity)
    {
      Random random = new Random();

      for (int i = 0; i < quantity; i++)
      {
        int randomNum = random.Next();
        numbers.Add(randomNum);
      }

      return numbers;

    }

    public static (List<int>, string) RemoveElementFromList(List<int> numbers, int element)
    {
      int removedCount = numbers.RemoveAll(x => x == element);

      string message = $"{removedCount} occurrence(s) of {element} removed.";

      return (numbers, message);

    }

    public static bool CheckElementInList(List<int> numbers, int element)
    {
      return numbers.Contains(element);

    }

    public static int FindMax(List<int> numbers)
    {
      if (numbers.Count == 0)
      {
        throw new ArgumentException("The list cannot be empty.");
      }

      int max = numbers[0];
      foreach (int num in numbers)
      {
        if (num > max)
        {
          max = num;
        }
      }
      return max;

    }
    public static int FindMin(List<int> numbers)
    {
      if (numbers.Count == 0)
      {
        throw new ArgumentException("The list cannot be empty.");
      }

      int min = numbers[0];
      foreach (int num in numbers)
      {
        if (num < min)
        {
          min = num;
        }
      }
      return min;

    }
    public static double CalculateAverage(List<int> numbers)
    {
      if (numbers.Count == 0)
      {
        throw new ArgumentException("The list cannot be empty.");
      }

      int sum = 0;
      foreach (int num in numbers)
      {
        sum += num;
      }

      return (double)sum / numbers.Count;
    }

  }
}
