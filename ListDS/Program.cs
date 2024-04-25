using System;
using System.Collections.Generic;
namespace ListDS;
class Program{
    public static void Main(string[] args)
    {
        CustomList<int> numberList = new CustomList<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        CustomList<int> numbers = new CustomList<int>();
        numbers.Add(60);
        numbers.Add(70);
        numberList.AddRange(numbers);
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
        //foreach(int value in numberList){
         //   Console.WriteLine(value);
        //}
        bool result = numberList.Contains(40);
        int position = numberList.IndexOf(20);
        numberList.Insert(2,30);
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
        numberList.RemoveAt(2);
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
        bool  temp = numberList.Remove(40);  
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }      
        numberList.InsertRange(3,numbers);
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
        numberList.Reverse();
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
        numberList.Sort();
        for(int i=0;i<numberList.Count;i++){
            Console.WriteLine(numberList[i]);
        }
    }

}
