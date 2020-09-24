using System;

class MainClass {
  public static void Main (string[] args) {
    while (true) 
    {
      bool isPrime = true;
      Console.Write("Enter A Number: ");
      double n1 = double.Parse(Console.ReadLine());
      double n = Math.Abs(n1);
      for (int x = 2; x < n; x++)
      {
        if (n % x == 0)
        {
          isPrime = false;
          break;
        }
      }
      if (isPrime)
      {
        Console.WriteLine(n1 + " Is Prime");
      }
      else
      {
        Console.WriteLine(n1 + " Is Not Prime");
      }
    }
  }
}