namespace Gyakorlo_ZH
{
    public class Student : Person, IIdentifiable  
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Neptun { get; set; } = String.Empty;
        public int Credits { get; set; }
        
        public static int InstanceCount { get; private set; } = 0;

        public override string GetInfo()
        {
            return $"{Name} ({Neptun}), életkor: {Age}, kreditek: {Credits}";
        }

        public string GetNeptunCode()
        {
            return Neptun;
        }

        public Student()
        {
            InstanceCount++;
        }
        
        
    }
}
