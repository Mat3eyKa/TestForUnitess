using System.Linq;
using TestForUnitess.Models;

namespace TestForUnitess.Data
{
    public class DbInitializer
    {
        public static void Initialize(UnitessContext context)
        {
            if (context.Events.Any())
                return;

            context.Events.AddRange(new Person[]
            {
                new Person {Name = "Матвей", Surname = "Лемешев1" },
                new Person {Name = "Матвей", Surname = "Лемешев2" },
                new Person {Name = "Матвей", Surname = "Лемешев3" },
                new Person {Name = "Матвей", Surname = "Лемешев4" },
                new Person {Name = "Матвей", Surname = "Лемешев5" },
                new Person {Name = "Матвей", Surname = "Лемешев6" },
                new Person {Name = "Матвей", Surname = "Лемешев7" },
                new Person {Name = "Матвей", Surname = "Лемешев8" },
                new Person {Name = "Матвей", Surname = "Лемешев9" },
                new Person {Name = "Матвей", Surname = "Лемешев10" },
            });
            context.SaveChanges();
        }
    }
}
