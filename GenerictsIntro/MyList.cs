using System;
using System.Collections.Generic;
using System.Text;

namespace GenerictsIntro
{
    class MyList<T>
    {
        T[] items;//items array oluşturuldu
        public MyList()//cons oluşturdum
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;// geçici eleman tutuluyor
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//eklenen son elemanı tuttu
            }
            items[items.Length - 1] = item;//tutulan elemanı listeye ekledi
        }
    }
}
