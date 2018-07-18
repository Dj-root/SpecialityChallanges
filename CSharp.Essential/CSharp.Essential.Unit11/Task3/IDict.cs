namespace CSharp.Essential.Unit11
{
    public interface IDict<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        int GetDictCapacity();
    }
}