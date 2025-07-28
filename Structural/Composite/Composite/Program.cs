using Composite;
using File = Composite.File;

IFileSystemComponent file1 = new File("File1.txt");
IFileSystemComponent file2 = new File("File2.txt");
IFileSystemComponent file3 = new File("File3.txt");

var folder1 = new Folder("Folder1");
var folder2 = new Folder("Folder2");

folder1.AddComponent(file1);
folder1.AddComponent(file2);

folder2.AddComponent(folder1);
folder2.AddComponent(file3);

Console.WriteLine("Folder structure:");
folder2.ShowDetails();

Console.WriteLine("\nDeleting folder2:");
folder2.Delete();