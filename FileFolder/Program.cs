using System;
using System.IO;
namespace FileFolder;
class Program{
    public static void Main(string[] args)
    {
        string path =@"C:\Users\PriyadharshiniKesava\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Priya";
        if(!Directory.Exists(folderPath)){
            Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory(folderPath);
        }
        else{
            Console.WriteLine("Folder already exists");
        }
        string filepath=path+"/myFile.txt";
        if(!File.Exists(filepath)){
            Console.WriteLine("Creating file...");
            File.Create(filepath);
        }else{
            Console.WriteLine("File already Exists");
        }

        //getting file name from the user and creating file

        Console.WriteLine("Select 1. Create Folder\n2. Create file\n3. Delete Folder\n4. Delete File");
        int option = int.Parse(Console.ReadLine());
        switch(option){
            case 1:{
                Console.WriteLine("Enter folder name you want to create ");
                string folder = Console.ReadLine();
                string newPath=path+"/"+folder;
                if(!Directory.Exists(newPath)){
                    Console.WriteLine("Creating folder..."+folder);
                    Directory.CreateDirectory(newPath);
                }
                else{
                    Console.WriteLine("Folder already exists");
                }
                break;
            }
            case 2:{
                Console.WriteLine("Enter file Name: ");
                string file = Console.ReadLine();
                Console.WriteLine("Enter file Extension: ");
                string extension = Console.ReadLine();
                string newFilePath = path+"/"+file+"."+extension;
                if(!File.Exists(newFilePath)){
                    Console.WriteLine("Creating file..."+file+"."+extension);
                    File.Create(newFilePath);

                }
                else{
                    Console.WriteLine("File already Exists");
                }
                break;
            }
            case 3:{
                foreach(string path1 in Directory.GetDirectories(path)){
                    Console.WriteLine(path1);
                }
                Console.WriteLine("Select the folder you wish to remove ");
                string folder1 = Console.ReadLine();
                foreach(string path1 in Directory.GetDirectories(path)){
                    if(path1.Contains(folder1)){
                        Console.WriteLine("Removing Folder.."+folder1);
                        Directory.Delete(path1);

                    }
                }
                break;

            }
            case 4:{
                foreach(string file1 in Directory.GetFiles(path)){
                    Console.WriteLine(file1);
                }
                Console.WriteLine("Select the file and extension you wish to remove ");
                string file2 = Console.ReadLine();
                foreach(string file1 in Directory.GetFiles(path)){
                    if(file1.Contains(file2)){
                        Console.WriteLine("Removing File.."+file2);
                        File.Delete(file1);

                    }
                }
                break;

            }
        }
    }
}