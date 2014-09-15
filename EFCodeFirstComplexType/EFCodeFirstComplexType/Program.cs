using System;

namespace EFCodeFirstComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student
                {
                    Id = 1,
                    FirstName = "Jalpesh",
                    LastName = "Vadgama",
                    StudentAddress = new Address()
                };
                using (var studentContext = new StudentContext())
                {
                    studentContext.Students.Add(student);
                    studentContext.SaveChanges();
                }
            }
            catch (Exception exception)
            {
              Console.WriteLine(exception.Message);
            }
        }
    }
}
