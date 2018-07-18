using System.Collections;

namespace CSharp.Essential.Unit11
{
    public interface IArrayList:IEnumerable
    {
        void Add(object value);
        void Clear();
        int IndexOf(object value);
        void Insert(int pos, object value);
        int LastIndexOf(object value);
        void Remove(object value);
        void RemoveAt(int pos);
        
        int Count { get; }
        int Capacity { get; }
    }
}