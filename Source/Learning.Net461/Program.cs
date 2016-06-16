using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var titanicManifest = new List<TitanicPassenger>
            {
                new TitanicPassenger { Age = 5, Gender = "M", Survived = true},
                new TitanicPassenger { Age = 60, Gender = "M", Survived = false},
                new TitanicPassenger { Age = 18, Gender = "M", Survived = false},
                new TitanicPassenger { Age = 18, Gender = "F", Survived = true},
                new TitanicPassenger { Age = 1, Gender = "M", Survived = false}
            };

            var testPassenger = new TitanicPassenger { Age = 1, Gender = "F" };
            var property = typeof(TitanicPassenger).GetProperty(nameof(testPassenger.Survived));
        }
    }
}