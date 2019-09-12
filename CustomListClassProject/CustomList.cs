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
    private int capacity;
    public int Count { get => count; }
    public int Capacity { get => capacity; }
    public T this[int i] { get => items[i]; set => items[i] = value; }

    public CustomList()
    {
      items = new T[4];
      count = 0;
      capacity = 4;
    }

    public void Add(T item)
    {
      if (ListIsAtCapacity())
      {
        DoubleCapacity();
        T[] temporaryArray = new T[capacity];
        CopyArrayOneToArrayTwo(items, temporaryArray);
        items = new T[capacity];
        CopyArrayOneToArrayTwo(temporaryArray, items);
      }

      items[count] = item;
      count++;
    }

    public void Remove(T item)
    {
      CustomList<T> temporaryList = new CustomList<T>();
      for (int i = 0; i < count; i++)
      {
        if (items[i].Equals(item))
        {
          continue;
        }
        else
        {
          temporaryList.Add(items[i]);
        }
      }
      items = new T[capacity];
      count = 0;
      for (int i = 0; i < temporaryList.Count; i++)
      {
        items[i] = temporaryList[i];
        count++;
      }
    }

    private bool ListIsAtCapacity()
    {
      if (count == capacity)
      {
        return true;
      }
      return false;
    }

    private void DoubleCapacity()
    {
      capacity *= 2;
    }

    private void CopyArrayOneToArrayTwo(T[] arrayOne, T[] arrayTwo)
    {
      for (int i = 0; i < count; i++)
      {
        arrayTwo[i] = arrayOne[i];
      }
    }

    private void PointReferenceFromOldArrayToNewOne(T[] temporaryArray)
    {
      items = temporaryArray;
    }
  }
}
