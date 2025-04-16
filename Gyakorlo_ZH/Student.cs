namespace Gyakorlo_ZH
{
    internal class Student : Person
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string Neptun { get; set; } = String.Empty;
        public int Credits { get; set; }

        public override string GetInfo()
        {
            return $"{Name} ({Neptun}), életkor: {Age}, kreditek: {Credits}";
        }
    }
}
