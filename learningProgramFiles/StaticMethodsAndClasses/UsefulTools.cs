using System;

namespace csharp_learnin {
  static class UsefulTools { // keyword static type to stop creation of instance of UsefulTools class
    public static void SayHi(string name) {
      Console.WriteLine("Hello " + name);
    }
  }
}