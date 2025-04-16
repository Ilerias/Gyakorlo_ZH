namespace Gyakorlo_ZH
{
    public class Person
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }

        public virtual string GetInfo()
        {
            return $"Név: {Name}, Kor: {Age}";
        }

    }
}
