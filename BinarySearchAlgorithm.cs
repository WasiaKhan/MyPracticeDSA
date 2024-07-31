// This is Binary Search Algorithm written in C#


// Online C# Editor for free [https://www.programiz.com/csharp-programming/online-compiler/](https://www.programiz.com/csharp-programming/online-compiler/)

using System;
public class DSAAlgos
{
    public static void Main(string[] args)
    {
        int[] arrInp =  {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};
        int searchKey = -2;
        int result = BinarySearchAlgo(arrInp, searchKey);
        
        Console.Write("Array = ");
        foreach(var item in arrInp)
        {
            Console.Write(item.ToString());
            Console.Write(" ");
        }
        Console.Write("\n");
        Console.WriteLine("Search For = " + searchKey);
        Console.WriteLine(searchKey + " is found at index "+ Convert.ToString(result) + ".");
        
    }
    
    
    public static int BinarySearchAlgo(int[] inpArr, int searchChar )
    {
        
        int low, high, mid, pivot;
        low = high = mid = pivot = 0;
        
        int[] input = inpArr;
        int key = searchChar;
        
        high = input.Length;
       
       
        for (int i=0; i<input.Length+1; i++)
        {
            mid = (high + low) / 2;   
            pivot = input[mid];
            
            if (pivot == key)
            {
                break;
            }
            
            else
            {
                if (pivot > key)
                {
                   high = mid;
                }
                else 
                { 
                    low = mid;
                }
            }
          
        }
    
        if (input[mid] == key)
        {
            return mid;   
        }
        else
        {
            return  -1 ;
        }
            
    }
}
