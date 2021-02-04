using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//referans numarasını tutar.
            items = new T[items.Length + 1];//dizideki eleman sayısını arttırıyor

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//tutulan diziyi tarar
            }
            items[items.Length - 1] = item;//diziye yeni elemanı ekler
        }
        public int Length// items uzunluğu döner
        {
            get { return items.Length; }
        }
        public T[] Items//items arry değeri döner
        {
            get { return items; }
        }
    }
}
