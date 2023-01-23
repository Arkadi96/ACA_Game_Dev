namespace temp
{
    class temp
    {
        static int getMiddleAge(Person[] p)
        {
            UInt16 midAge = 0;
            for (int i = 0; i < p.Length; ++i)
            {
                midAge += p[i].age;
            }
            return midAge / p.Length;
        }

        static void Main()
        {
            Person[] p = new Person[4];
            p[0].setPerson("Hke", "Sleyan", 14, "female");
            p[1].setPerson("Sqe", "Gleyan", 8, "male");
            p[2].setPerson("Hke", "Vrkeyan", 31, "emale");
            p[3].setPerson("Zyzz", "SHahvershian", 28, "female");

            Console.WriteLine($"\nFirst assignment");
            Console.WriteLine($"The middle age is: {getMiddleAge(p)} \n");

            Console.WriteLine($"\nSecond assignment");
            Employee e = new Employee();
            e.setEmployee("Gojo", "Muxyan", "gandzapah", 250);
            p[0] = e; // Hke Sleyan -> Gojo Muxyan
            p[0].print();
            e = p[1]; // Gojo Muxyan -> Sqe Gleyan
            e.print();

            Console.WriteLine($"\nThird assignment");
            Point p1 = new Point(1,2,3);
            Point p2 = new Point(2,3,4);
            Point p3 = p1 + p2;
            Console.WriteLine($"New point values are: {p3.x}, {p3.y}, {p3.z} \n");
        }
    }

    struct Person
    {
        public string firstName;
        public string lastName;
        public UInt16 age;
        public string gender;

        public void setPerson(string f, string l, UInt16 a, string g)
        {
            firstName = f;
            lastName = l;
            age = a;
            gender = g;
        }

        public static implicit operator Person(Employee e)
        {
            Person p = new Person();
            p.setPerson(e.firstName, e.lastName, 0, "undefined");
            return p;
        }

        public void print()
        {
            Console.WriteLine($"\nFirst name: {firstName} " +
                $"\nLast name: {lastName}" +
                $"\nAge: {age}" +
                $"\nGender: {gender}");
        }
    };

    struct Employee
    {
        public string firstName;
        public string lastName;
        public string positionName;
        public UInt16 salary;

        public void setEmployee(string f, string l, string p, UInt16 s)
        {
            firstName = f;
            lastName = l;
            positionName = p;
            salary = s;
        }

        public static implicit operator Employee(Person p)
        {
            Employee e = new Employee();
            e.setEmployee(p.firstName, p.lastName, "Undefined", 0);
            return e;
        }

        public void print()
        {
            Console.WriteLine($"\nFirst name: {firstName} " +
                $"\nLast name: {lastName}" +
                $"\nPosition: {positionName}" +
                $"\nSalary: {salary}$");
        }
    };

    struct Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator + (Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
        
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p2.x - p1.x, p2.y - p1.y, p2.z - p1.z);
        }

        public static Point operator /(Point p1, Point p2)
        {
            return new Point(p2.x / p1.x, p2.y / p1.y, p2.z / p1.z);
        }

        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p2.x * p1.x, p2.y * p1.y, p2.z * p1.z);
        }
    };
}
