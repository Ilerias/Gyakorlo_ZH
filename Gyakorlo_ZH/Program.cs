using System.Text.Json;

namespace Gyakorlo_ZH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("students.json");

            var students = JsonSerializer.Deserialize<List<Student>>(json);
            
            var studentRepo = new Repository<Student>();

            foreach (var student in students)
            {
                Console.WriteLine($"Név: {student.Name}, Kredit: {student.Credits}");
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.GetInfo());
            }
            
            Console.WriteLine($"\nPéldányok száma: {Student.InstanceCount}");

            foreach (var student in students)
            {
                studentRepo.Add(student);
            }
            
            var search = studentRepo.Find(s => s.Neptun == "XYZ789");

            if (search != null)
            {
                Console.WriteLine("\nKeresett hallgató:");
                Console.WriteLine(search.GetInfo());
                
                var cert = new StudentCertificate(search);
                Console.WriteLine("\nIgazolás:");
                cert.Print();
            }
            else
            {
                Console.WriteLine("Nincs ilyen Neptun-kódú hallgató.");
            }
            
            Console.WriteLine($"\nPéldányok száma: {Student.InstanceCount}");

            var MoreThanFourty = students.Where(s => s.Credits > 40).OrderByDescending(s => s.Name);

            foreach (var student in MoreThanFourty)
            {
                Console.WriteLine($"{student.Name} - {student.Credits}");
            }
        }
    }
}
