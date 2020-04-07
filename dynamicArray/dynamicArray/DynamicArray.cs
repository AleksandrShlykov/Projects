using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace task1
{
  class DynamicArray<T> : System.Collections.IEnumerable
  {
    private int _size;
    private int _lenght;
    public int _Lenght{
      get { return _lenght; }
}
    public int _Size
    {
      get { return _size; }
    }
    private T[] _items;
    public T this[int i] {
      get { return _items[i]; }
      set {
        try
        {
          _items[i] = value;
        }
        catch (IndexOutOfRangeException outOfRange)
        {
          Console.WriteLine(outOfRange.Message);
        }
      }
    }

    public DynamicArray()
    {
      _size = 8;
      _items = new T[_size];
    }
    public DynamicArray(int capacity)
    {
      _size = capacity;
      _items = new T[_size];
    }
    public DynamicArray(T[] array)
    {
      _items = array;
      _size = array.Length;
      _lenght = array.Length;
    }
    public void Add(T _item)
    {
      if (_size <= _lenght)
      {
        _size *= 2;
       T[] _newItems = new T[_size];
        for (int i=0; i<_items.Length;i++)
        {
          _newItems[i] = _items[i];
        }
        _items = _newItems;
        _items[_lenght] = _item;
        _lenght++;
      }
      else
      {
        _items[_lenght] = _item;
        _lenght++;
      }
    }
    public void AddRange(T[] array){
      if (_size <= _lenght + array.Length)
      {
        _size += array.Length;
        T[] _newItems = new T[_size];
        for (int i = 0; i < _items.Length; i++)
        {
          _newItems[i] = _items[i];
        }
        _items = _newItems;
        for (int i = _lenght; i < _items.Length; i++)
        {
          _items[i] = array[i-_lenght];
        }
        _lenght++;

      }
      else
      {
        for (int i = _lenght; i < _items.Length; i++)
        {
          _items[i] = array[i - _lenght];
        }
        _lenght++;
      }
    }
    public bool Remove(T _item)
    {
      Console.WriteLine("item"+(object)_item);
      for (int i = 0; i < _size; i++)
      {
      }
      foreach(T element in _items)
      {

      }
      return true;
    }
    public void Insert(T _item, int _position)
    {
      try 
      {
        for (int i = _lenght; i >= _position; i--)
        {
          _items[i] = _items[i - 1];
        }
        _items[_position-1] = _item;
        _lenght++;
      }
      catch (IndexOutOfRangeException outOfRange)
      {
        Console.WriteLine(outOfRange.Message);
        _size *= 2;
        T[] _newItems = new T[_size];
        for (int i = 0; i < _items.Length; i--)
        {
          _newItems[i] = _items[i];
        }
        _items = _newItems;
        for (int i = _lenght; i > _position; i++)
        {
          _items[i] = _items[i - 1];
        }
        _items[_position - 1] = _item;
        _lenght++;
      }
  
    }

    public IEnumerator GetEnumerator()
    {
      for (int i = 0; i <= _lenght; i++)
      {
        yield return _items[i];
      }
    }
  }
 
 
}
