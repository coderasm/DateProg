using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProg
{
  class Program
  {
    static void Main(string[] args)
    {
      var date = new Date(31, 1, 1900);
      var differenceInDays = date.numberOfDaysSince(1900);
      Console.WriteLine(differenceInDays.ToString());
      date.isLater(new Date(23, 5, 1923));
      date.isEarlier(new Date(23, 5, 1923));
      Console.ReadKey();
    }
  }
}
