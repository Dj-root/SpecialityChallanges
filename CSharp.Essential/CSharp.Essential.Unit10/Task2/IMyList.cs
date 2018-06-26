namespace CSharp.Essential.Unit10
{
    public interface IMyList<T>
    {
        T this[int index] { get; }
        void AddItem(T item);
        int Length { get; }
    }
}