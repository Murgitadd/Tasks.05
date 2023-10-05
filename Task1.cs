using System;

class Program {
  
  public static void Main (string[] args) {
    
    int[] initialArr = new int [6] {4, 7, 3, 6, 2, 7};

      InsertArray(initialArr, 5,7,8,45324344,1);
    
  }

  static void InsertArray (int[] arr, params int[] nums)
  {

    int[] firstArr = new int[arr.Length+nums.Length];

    for (int i=0; i<firstArr.Length; i++)
    {
      if (i<arr.Length)
      {
        firstArr[i]=arr[i];
      }
      else
      {
        firstArr[i]=nums[i-arr.Length];
      }
    }

    for (int i=0; i<firstArr.Length; i++)
    {
      Console.WriteLine($"{i}.index : {firstArr[i]}");
    }
    
  }

  
}
