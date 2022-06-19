// See https://aka.ms/new-console-template for more information

using SamConsoleApp1;

namespace SamConsoleApp1;

class Program
{  // Samuel Kiarie -- 06/18/2022
    static void Main(string[] args)
    {
        // instantiate Employee objects
        Employee employee1 = new Employee();
        Employee employee2 = new Employee();
        employee1.FirstName = "Kenny";
        employee1.LastName = "Rogers";
        employee1.Title = "CEO";

        employee2.FirstName = "Sarah";
        employee2.LastName = "Byod";
        employee2.Title = "Manager";


        // instantiate Student objects
        var student1 = new Student();
        student1.FirstName = "Samuel";
        student1.LastName = "Kiarie";
        student1.TotalStudyTime = 240;

       // // call SayHello() method for employee1
       // employee1.SayHello();
       // employee1.SayGoodbye();


       // // call SayGoodbye() method for employee2
       //employee2.SayHello();
       //employee2.SayGoodbye();

        // call SayHello() method for student1
        student1.SayHello();

        // call Study() method for student1
        student1.Study();

        // call SayGoodbye() method for student1
        student1.SayGoodbye();

    }

}


