using System;

namespace csharp_learnin {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine(Math.Sqrt(144)); // class called Math in csharp, we didn't have to create an instance of Math class and just using it's static method
      UsefulTools.SayHi("Andrea"); // did not have to create an instance of UsefulTools to access the method
      Console.ReadLine();
    }
  }
}

// static method is a method belonging to the class itself, don't have to create an object of that class to access it
// usually when creating a method it applies to the instance or object of that class