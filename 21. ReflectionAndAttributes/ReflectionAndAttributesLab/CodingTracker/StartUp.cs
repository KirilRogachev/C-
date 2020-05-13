using System;

namespace CodingTracker
{
    [Author("Ventsi")]
   public class StartUp
    {
        [Author("Gosho")]
      public static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
        [Author("Kiro")]
        public void Test()
          {
          var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
        }
}
}
