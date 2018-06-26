using System;

namespace CSharp.Essential.Unit10
{
    public class MyFactory<T> where T : new()   
    {
        public static T FactoryMethod()
        {
            return new T();
        }

        
    }
    
}