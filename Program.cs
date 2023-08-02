using System;

namespace Phase1Section5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Subject algebra = new Subject();
            algebra.Name = "Algebra";

            Subject physics = new Subject();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr.Algebra";
            algebraTeacher.ContactAddress = "Some Address";
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr.Physics";
            physicsTeacher.ContactAddress = "Some Address";
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            physicsTeacher.WhichSubject = physics;

            CClass class8 = new CClass();
            class8.Name = "8";

            ClassTeacher teacherOf8 = new ClassTeacher();
            teacherOf8.Name = "Mrs.Class 8 Teachers";
            teacherOf8.ContactAddress = "Some Address";
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            teacherOf8.WhichClass = class8;

            class8.WhichTeacher = teacherOf8;

            

            Console.WriteLine($"Algebra Teacher: {algebraTeacher.Name}");
            Console.WriteLine($"Teaching Subject: {algebraTeacher.WhichSubject.Name}");
            Console.WriteLine($"Joining Date: {algebraTeacher.DateOfJoining}");
            Console.WriteLine($"Contact Address: {algebraTeacher.ContactAddress}");
            Console.WriteLine();

            
            Console.WriteLine($"Physics Teacher: {physicsTeacher.Name}");
            Console.WriteLine($"Teaching Subject: {physicsTeacher.WhichSubject.Name}");
            Console.WriteLine($"Joining Date: {physicsTeacher.DateOfJoining}");
            Console.WriteLine($"Contact Address: {physicsTeacher.ContactAddress}");
            Console.WriteLine();

            
            Console.WriteLine($"Class 8: {class8.Name}");
            Console.WriteLine($"Class Teacher: {teacherOf8.Name}");
            Console.WriteLine($"Joining Date: {teacherOf8.DateOfJoining}");
            Console.WriteLine($"Contact Address: {teacherOf8.ContactAddress}");

            Console.ReadKey();
        }
    }
}
