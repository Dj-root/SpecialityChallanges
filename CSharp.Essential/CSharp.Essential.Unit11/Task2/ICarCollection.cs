using CSharp.Essential.Unit11;

namespace CSharp.Essential
{
    public interface ICarCollection<T>
    {
        void Add(T car);
        int GetCarsCapacity();
        void Clear();
    }
}