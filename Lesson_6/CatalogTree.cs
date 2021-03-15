using System;
using System.Collections.Generic;
using System.IO;

namespace CatalogTree
{
    class CatalogTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь");
            string path = Console.ReadLine();
            Tree(path);
        }

        static void Tree(string root)
        {
            string[] file = Directory.GetFiles(root); // Создаем массив из файлов в по данному пути
            File.AppendAllLines("Tree.txt",file);

            string[] dirCatalog = Directory.GetDirectories(root); // Создаем массив из вложенных папок по заданному пути
            foreach (var item in dirCatalog)
            {
                string[] files = Directory.GetFiles(item); // Создаем массив из файлов в каждой вложенной папке
                File.AppendAllLines("Tree.txt", files);
            }
        }
    }
}
