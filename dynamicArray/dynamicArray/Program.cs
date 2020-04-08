using System;

namespace task1
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] Ar = new int[4];
      Ar[0] = 1;
      Ar[1] = 2;
      Ar[2] = 3;
      Ar[3] = 4;
      DynamicArray<int> dA = new DynamicArray<int>(Ar);
      for (int i = 0; i < dA.Size; i++)
      {
        Console.Write(dA[i]+" ");
      }
      Console.WriteLine();
      Console.WriteLine("Введите число для операции Add");
      int b = Int32.Parse(Console.ReadLine());
      dA.Add(b);
      for (int i = 0; i < dA.Size; i++)
      {
        Console.Write(dA[i]+" ");
      }
      Console.WriteLine();
      Console.WriteLine("Введите число для операции Remove");
      b = Int32.Parse(Console.ReadLine());
      if (dA.Remove(b))
      {
        Console.WriteLine("Удаление прошло успешно");
      }
      else
      {
        Console.WriteLine("Выбранного элемента нет в коллекции");
      }
      for (int i = 0; i < dA.Size; i++)
      {
        Console.Write(dA[i] + " ");
      }
      Console.WriteLine();
      for (int k=0;k<3;k++) {
        Console.WriteLine("Введите число для операции Insert");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите позицию числа для операции Insert");
        int p = Int32.Parse(Console.ReadLine());
        dA.Insert(b, p);
        for (int i = 0; i < dA.Size; i++)
        {
          Console.Write(dA[i] + " ");
        }
        Console.WriteLine();
      }
     foreach(int element in dA)
      {
        Console.WriteLine("element=" + element);
      }
    }
  }
}
