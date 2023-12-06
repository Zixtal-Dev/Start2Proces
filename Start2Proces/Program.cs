using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

// See https://aka.ms/new-console-template for more information

try
{
    string Path1 = "";
    string Path2 = "";
    string TextFilePath = @"C:\InsitePaths.txt";
    if (!File.Exists(TextFilePath))
    {
        StreamWriter wr = new StreamWriter(TextFilePath);
        Console.WriteLine("Inserta la ruta del insite.exe: ");
        Path1 = Console.ReadLine();
        wr.WriteLine(Path1);
        Console.WriteLine("Inserta la ruta del Patcher");
        Path2 = Console.ReadLine();
        wr.WriteLine(Path2);
        wr.Close();


    }
    else
    {
        StreamReader rd = new StreamReader(TextFilePath);
        Path1 = rd.ReadLine();
        Console.WriteLine(Path1);
        Path2 = rd.ReadLine();
        Console.WriteLine(Path2);
        rd.Close();
    }
    Process MyProces1 = new Process();
    Process MyProces2 = new Process();
    MyProces1.StartInfo.FileName = Path1;
    MyProces2.StartInfo.FileName = Path2;
    MyProces1.Start();
    Thread.Sleep(2000);
    MyProces2.Start();
    MyProces1.WaitForExit();
    MyProces2.WaitForExit();
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message); 
    Console.ReadLine();
}
