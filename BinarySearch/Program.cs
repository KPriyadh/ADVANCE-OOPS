using System;
namespace BinarySearch;
class Program{
    public static void Main(string[] args)
    {
        int[]  values = {12,13,21,10,8,11,9};
        Array.Sort(values);
        int position = BinarySearch(values,10);
        if(position>-1){
            Console.WriteLine("Element found at "+position);

        }
        else{
            Console.WriteLine("Element Not found");
        }

    }
    static int BinarySearch(int[] values,int searchElement){
        int left=0; int right =values.Length-1;
        while(left<=right){
            int middle = left+((right-left)/2);
            if(values[middle]==searchElement){
                return middle;
            }
            else if(values[middle]<searchElement){
                left=middle+1;
            }
            else{
                right=middle-1;
            }
        }
        return -1;
    }
}