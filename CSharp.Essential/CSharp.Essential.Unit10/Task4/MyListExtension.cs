namespace CSharp.Essential.Unit10
{
   static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[]listArray = new T[list.Length];

            for (int i = 0; i < listArray.Length; i++)
            {
                listArray[i] = list[i];
            }
            
            return listArray;
        }
    }
}