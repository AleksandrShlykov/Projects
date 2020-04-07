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

      DynamicArray<int> dA2 = new DynamicArray<int>(7);
      for (int i = 0; i < dA._Size; i++)
      {
        Console.WriteLine(dA[i]);
      }
      dA.Add(7);
      dA.Insert(9,3);
      for (int i = 0; i < dA._Size; i++)
      {
        Console.WriteLine(dA[i]);
      }
      Console.WriteLine(dA._Lenght);
     foreach(int element in dA)
      {
        Console.WriteLine("element=" + element);
      }
    }
  }
}
