using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace pesebrera.Persistence
{
    public class FileManager
    {
        private string _filePath;

        public FileManager(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
                _filePath = filePath;
            else
                throw new ArgumentException("Dirección del archivo invalida", "filePath");
        }

        public string[] ReadFile()
        {
            string [] readText = File.ReadAllLines(_filePath);
            return readText;
        }

        public void WriteFile(string[] newText)
        {
            File.WriteAllLines(_filePath, newText);
        }
    }
}