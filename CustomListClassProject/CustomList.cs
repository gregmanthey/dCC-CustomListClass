using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
  public class CustomList<T>
  {
    private T[] items;
    private int count;
    public int Count { get => count; }
    public T this[int i] { get => items[i]; set => items[i] = value; }

    public CustomList()
    {
      items = new T[4];
    }

    public void Add(T item)
    {
      if (count == items.Length)
      {
        int newArrayLength = items.Length * 2;
        T[] temporaryArray = new T[newArrayLength];
        for (int i = 0; i < count; i++)
        {
          temporaryArray[i] = items[i];
        }
        items = new T[newArrayLength];
        for (int i = 0; i < count; i++)
        {
          items[i] = temporaryArray[i];
        }
      }

      items[count] = item;
      count++;
    }
  }
}
