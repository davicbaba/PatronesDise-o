using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatronesDiseno.Facade
{
    public class FileManager
    {
        public int CountCharacters(string fileName)
        {
            string fullFilePath = GetAbsolutePath(fileName);

            if (File.Exists(fullFilePath) == false)
                throw new FileNotFoundException("El archivo que especificaste no existe");

            int characterCount = 0;

            string[] lines = File.ReadAllLines(fullFilePath);

            foreach (string line in lines)
            {
                characterCount += line.Length;
            }

            return characterCount;
        }

        /// <summary>
        /// Retorna la ruta absoluta de donde se encuentra el archivo.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetAbsolutePath(string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            return string.Format("{0}Resources\\{1}", path, fileName);

        }

    }
}
