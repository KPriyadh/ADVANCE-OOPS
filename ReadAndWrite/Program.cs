using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
namespace ReadAndWrite;
class Program{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder")){
            Console.WriteLine("Creating folder ...");
            Directory.CreateDirectory("TestFolder");
        }
        else{
            Console.WriteLine("Directory exists");
        }
        if(!File.Exists("TestFolder/Data.csv")){
            Console.WriteLine("Creating file...");
            File.Create("TestFolder/Data.csv").Close();
        }
        else{
            Console.WriteLine("CSV file already exists");
        }
        if(!File.Exists("TestFolder/Data1.json")){
            Console.WriteLine("Creating JSON file...");
            File.Create("TestFolder/Data1.json").Close();
        }
        else{
            Console.WriteLine("JSON file already exists");
        }
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student(){Name="priya", FatherName="kesavan",Gender= Gender.Female,DOB = new DateTime(2001,07,29),Mark=100 });
        studentList.Add(new Student(){Name="Sai", FatherName="thiru",Gender= Gender.Male,DOB = new DateTime(2002,07,29),Mark=100 });
        studentList.Add(new Student(){Name="Riya", FatherName="kesavan",Gender= Gender.Female,DOB = new DateTime(2001,07,29),Mark=100 });
        WriteToCSV(studentList);
        ReadCSV();
        WriteToJSON(studentList);
        ReadJSON();

    }
    static void WriteToCSV(List<Student> studentList){
        StreamWriter sw = new StreamWriter("TestFolder/Data.csv");
        foreach(Student student in studentList)
        {
            string line = student.Name+","+student.FatherName+","+student.Gender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.Mark;
            sw.WriteLine(line);
        }
        sw.Close();

    }
    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data.csv");
        string line = sr.ReadLine();
        while(line!=null){
            string[] values = line.Split(",");
            if(values[0]!=""){
                Student student = new Student(){
                    Name=values[0],FatherName= values[1],Gender = Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),Mark=int.Parse(values[4])
                };
                newList.Add(student);

            }
            line=sr.ReadLine();

        }
        sr.Close();
        foreach(Student student in newList){
            Console.WriteLine("Name: "+student.Name+" FatherName: "+student.FatherName);
            Console.WriteLine(" Gender: "+student.Gender+" DOB: "+student.DOB.ToString("dd/MM/yyyy")," Marks: "+student.Mark);

        }
    }

    static void WriteToJSON(List<Student> studentList){
        StreamWriter sw = new StreamWriter("TestFolder/Data1.json");
        var option = new JsonSerializerOptions{
            WriteIndented=true

        };
        string jsonData = JsonSerializer.Serialize(studentList,option);
        sw.WriteLine(jsonData);
        sw.Close();

    }
    static void ReadJSON(){
        //StreamReader sr = new StreamReader("TestFolder/Data1.json");
        List<Student> students =JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data1.json"));
        foreach(Student student in students){
            Console.WriteLine("Name: "+student.Name+" FatherName "+student.FatherName);
            Console.WriteLine(" Gender: "+student.Gender+" DOB: "+student.DOB.ToString("dd/MM/yyyy")," Marks: "+student.Mark);

        }

    }
}