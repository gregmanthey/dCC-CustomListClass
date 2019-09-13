﻿using System;
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
    public T this[int i]
    {
      get
      {
        if (i < 0 || i >= count)
        {
          throw new IndexOutOfRangeException();
        }
        else
        {
          return items[i];
        }
      }
      set
      {
        if (i < 0 || i >= count)
        {
          throw new IndexOutOfRangeException();
        }
        else
        {
          items[i] = value;
        }
      }
    }

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
        CopyFromItemsArrayToTemporaryArray(temporaryArray);
        PointReferenceOfItemsArrayToNewLocation(temporaryArray);
        }

      items[count] = item;
      count++;
    }

    public void Remove(T item)
    {
      for (int i = 0; i < count; i++)
      {
        if (items[i].Equals(item))
        {
          RemoveAt(i);
        }

      }
    }

    public void RemoveAt(int index)
    {
      count--;
      for (int i = index; i < count; i++)
      {
        items[i] = items[i + 1];
      }
    }

    public void RemoveAll(T item)
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

    private void CopyFromItemsArrayToTemporaryArray(T[] temporaryArray)
    {
      for (int i = 0; i < count; i++)
      {
        temporaryArray[i] = items[i];
      }
    }

    private void PointReferenceOfItemsArrayToNewLocation(T[] temporaryArray)
    {
      items = temporaryArray;
    }
   
    public override string ToString()
    {
      string listString = "";
      for (int i = 0; i < count; i++)
      {
        if (i + 1 == count)
        {
          listString += $"{items[i]}";
        }
        else
        {
          listString += $"{items[i]},";
        }
      }
      return listString;
    }
    public static CustomList<T> operator +(CustomList<T> customListOne, CustomList<T> customListTwo)
    {
      CustomList<T> resultingList = new CustomList<T>();
      resultingList.AddListToCurrentList(customListOne);
      resultingList.AddListToCurrentList(customListTwo);
      return resultingList;
    }
    private void AddListToCurrentList(CustomList<T> listToAdd)
    {
      for (int i = 0; i < listToAdd.Count; i++)
      {
        this.Add(listToAdd[i]);
      }
    }
  }
}
