using System;
namespace DictionaryDS;
class Program{
    public static void Main(string[] args)
    {
        CustomDictionary<string,string> mydictionary = new CustomDictionary<string, string>();
        mydictionary.Add("SF3001","DHARSHINI");
        mydictionary.Add("SF3002","SAI");
        mydictionary.Add("SF3002","PRIYA");
        mydictionary.Add("SF3003","RITHIP");
        foreach(KeyValue<string,string>data in mydictionary){
            Console.WriteLine("Key"+data.Key+"   "+"Value"+data.Value);
        }
        string name = mydictionary["SF3001"];
        Console.WriteLine("Name is: "+name);
        mydictionary["SF3001"]="SAI";
        string name1 = mydictionary["SF3001"];
        Console.WriteLine("Name is: "+name1);
        }
}