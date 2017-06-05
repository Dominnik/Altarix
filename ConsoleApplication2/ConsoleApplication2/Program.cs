using System;
using System.IO;

namespace TempConsoleProject
{
    class Program
    {
        static void Main()
        {
        
            Console.WriteLine("Введите путь к файлу и имя файла:");
           
            string fileName = Console.ReadLine();                
            if (File.Exists(fileName) != true)
            {  
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                {
                    Console.WriteLine("Новый файл создан!");
                  //  sw.WriteLine("Дратути");             
                }
            }
            else
            {                              
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Open, FileAccess.Write)))
                {
                    Console.WriteLine("Файл открыт");

                    Console.WriteLine("Введите текст для записи или нажмите Enter для просмотра файла:");
                    string textforfile = Console.ReadLine();
                    (sw.BaseStream).Seek(0, SeekOrigin.End);        
                    sw.WriteLine(textforfile);
                    if (textforfile != "")
                    {
                        Console.WriteLine("Запись сохранена!");
                    }
                }
            }
            try
            {                             
                string[] allText = File.ReadAllLines(fileName);       
                foreach (string s in allText)
                {     
                    Console.WriteLine(s);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}