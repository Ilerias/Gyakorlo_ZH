using System.Text.Json;

namespace Gyakorlo_ZH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("students.json");

            var students = JsonSerializer.Deserialize<List<Student>>(json);

            foreach (var student in students)
            {
                Console.WriteLine($"Név: {student.Name}, Kredit: {student.Credits}");
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.GetInfo());
            }
        }
    }
}
