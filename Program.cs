namespace oop_1
{
    internal class Program
    {

        #region question 1)
        //enum WeekDays
        //{
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}


        #endregion

        #region question 2)
        //struct Person
        //{
        //    public string Name;
        //    public int Age;
        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        #endregion

        #region question 3)
        //enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}

        #endregion

        #region question 4)
        //enum Permissions
        //{
        //    Read,
        //    Write,
        //    Delete,
        //    Execute
        //}
        #endregion

        #region question 5)
        //enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue
        //}
        #endregion

        #region question 6)
        //struct Point
        //{
        //    public double X;
        //    public double Y;
        //    public Point(double x, double y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public static double Distance(Point p1, Point p2)
        //    {
        //        double dx = p1.X - p2.X;
        //        double dy = p1.Y - p2.Y;
        //        return Math.Sqrt(dx * dx + dy * dy); 
        //    }
        //}

        #endregion

        #region question 7)
        //struct Person
        //{
        //    public string Name;
        //    public int Age;
        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}


        #endregion


        static void Main(string[] args)
        {
            //question 1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //question 2
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Ahmed", 30);
            //persons[1] = new Person("Mohamed", 25);
            //persons[2] = new Person("Ali", 35);

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            //question 3
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string seasonName = Console.ReadLine();

            //if (Enum.TryParse(seasonName, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            //question 4
            //List<Permissions> userPermissions = new List<Permissions>();

            //userPermissions.Add(Permissions.Read);
            //userPermissions.Add(Permissions.Write);
            //userPermissions.Add(Permissions.Execute);

            //userPermissions.Remove(Permissions.Write);

            //bool hasRead = userPermissions.Contains(Permissions.Read);
            //bool hasWrite = userPermissions.Contains(Permissions.Write);
            //bool hasDelete = userPermissions.Contains(Permissions.Delete);
            //bool hasExecute = userPermissions.Contains(Permissions.Execute);

            //Console.WriteLine($"User has Read permission: {hasRead}");
            //Console.WriteLine($"User has Write permission: {hasWrite}");
            //Console.WriteLine($"User has Delete permission: {hasDelete}");
            //Console.WriteLine($"User has Execute permission: {hasExecute}");

            //question 5 
            //Console.WriteLine("Enter a color (Red, Green, Blue): ");
            //string userColor = Console.ReadLine();
            //if (Enum.TryParse(userColor, true, out Colors color))
            //{

            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color input. Please enter a valid color (Red, Green, Blue).");
            //}

            //question 6
            //Console.WriteLine("Enter the coordinates for the first point:");
            //Console.Write("X: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the second point:");
            //Console.Write("X: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = Point.Distance(point1, point2);

            //Console.WriteLine($"The distance between the points is: {distance:F2}");

            //question 7
            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    persons[i] = new Person(name, age);
            //}

            //Person oldestPerson = persons[0];

            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}

            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name}, aged {oldestPerson.Age}.");
        }
    }
}
