namespace Gyakorlo_ZH
{
    
    public class StudentCertificate : Document
    {
        private Student student;

        public StudentCertificate(Student student)
        {
            this.student = student;
            Title = $"Igazolás: {student.Name} ({student.Neptun})";
        }

        public override void Print()
        {
            Console.WriteLine(Title);
            Console.WriteLine($"Kreditek száma: {student.Credits}");
        }
    }
}