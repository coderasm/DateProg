using System;

namespace DateProg
{
  class Program
  {
    static void Main(string[] args)
    {
      var referenceDate = new Date(1, 1, 1900);
      Date[] dates = {
        new Date(23, 4, 2019),
        new Date(2, 2, 2010),
        new Date(10, 9, 1900),
        new Date(1, 1, 1900),
        new Date(8, 6, 1856)
      };
      Console.WriteLine("Testing numberOfDaysSince, isEarlier, isTheSame and isLater");
      Console.WriteLine();
      foreach (var date in dates)
      {
        Console.WriteLine(date.print() + ": " + date.numberOfDaysSince(1900) + " days since 1/1/1900");
        date.isEarlier(referenceDate);
        date.isTheSame(referenceDate);
        date.isLater(referenceDate);
      }
      Console.WriteLine();
      Console.WriteLine("Testing nextDay, nextMonth, nextYear");
      Console.WriteLine();
      Date[] moreDates = {
        new Date(),
        new Date(1, 11, 2019),
        new Date(27, 2, 2019),
        new Date(28, 2, 2019),
        new Date(24, 12, 2019),
        new Date(31, 12, 2019)
      };
      foreach (var date in moreDates)
      {
        date.nextDay();
        date.nextMonth();
        date.nextYear();
      }
      Console.WriteLine();
      Console.WriteLine("Testing prevDay, prevMonth, prevYear");
      Console.WriteLine();
      Date[] evenMoreDates = {
        new Date(),
        new Date(1, 11, 2019),
        new Date(27, 2, 2019),
        new Date(28, 2, 2019),
        new Date(24, 12, 2019),
        new Date(31, 12, 2019),
        new Date(1, 1, 2020)
      };
      foreach (var date in evenMoreDates)
      {
        date.prevDay();
        date.prevMonth();
        date.prevYear();
      }
      Console.ReadKey();
    }
  }
}
