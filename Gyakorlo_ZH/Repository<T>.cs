namespace Gyakorlo_ZH
{
    
    public class Repository<T>
    {
        public List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Find(Func<T, bool> predicate)
        {
            return items.FirstOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }
    
}