using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Joe Lehman",
    EmailAddress = "joejr65@live.com",
    DateOfBirth = new DateTime(1965, 5, 1)
};



// Prepares the Student insert statement
dbContext.Students.Add(s);

// Executes pending insert or any other pending inserts.
dbContext.SaveChanges();

Student s2 = new()
{
    FullName = "James Lehman",
    EmailAddress = "lehman5247@students.cptc.edu",
    DateOfBirth = new DateTime(1967, 3, 30)
};

Student s3 = new()
{
    FullName = "Cheryl Lehman",
    EmailAddress = "lehman5253@students.cptc.edu",
    DateOfBirth = new DateTime(1944, 9, 10)
};

dbContext.Students.Add(s2);
dbContext.Students.Add(s3);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method Syntax

// allStudents = (from stu in dbContext.Students select stu).ToList(); // Query Syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}