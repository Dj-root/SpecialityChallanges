using System;
using System.Collections.Generic;

namespace CSharp.Essential.Unit11
{
    public class CarCollection<T> : ICarCollection<T>
    {
        List<T> carList = new List<T>();

        public T this[int index]
        {
            get { return carList[index]; }
        }

        public void Add(T car)
        {
            carList.Add(car);
        }

        public int GetCarsCapacity()
        {
            return carList.Capacity;
            //throw new System.NotImplementedException();
        }

        public void Clear()
        {
            carList = new List<T>();
            Console.WriteLine("CarCollection cleared");
        }
        
        
    }
}