namespace F24W4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 5, 6, 7, 4, 2, 3, 5, 6, 3, 5 };

            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


            List<string> colors = new List<string>();
            colors.Add("rEd");
            colors.Add("brOWn");
            colors.Add("grEEn");
            colors.Add("PiNk");
            colors.Add("BlUe");

            var startsWithB = from c in colors
                              let uppcaseColors = c.ToUpper()
                              where uppcaseColors.StartsWith("B")
                              orderby uppcaseColors
                              select uppcaseColors;

            foreach (var c in startsWithB)
                Console.WriteLine(c);
            Console.WriteLine("\n\n");

            colors.Add("bLaCk");
            colors.Add("OranGE");

            // deferred execution
            foreach (var c in startsWithB)
                Console.WriteLine(c);
            Console.WriteLine("\n\n\n\n");



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Brown", 4000),
                new Employee("Anne", "Green", 6000),
                new Employee("Katie", "Indigo", 3000),
                new Employee("James", "Indigo", 5000),
                new Employee("Sam", "Green", 4500),
                new Employee("John", "White", 7000)
            };


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var e in between4k6k)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var e in sortedEmps)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var lastnames = from e in employees
                            orderby e.LastName
                            select e.LastName;

            foreach (var e in lastnames.Distinct())
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var e in empNames)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");
        }
    }
}
