using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFiles
{
    public class FindFiles
    {
        private string _filePath;
        private string _fileName;

        public FindFiles(string filePath, string fileName)
        {
            _filePath = filePath;
            _fileName = fileName;
        }

        public bool DeleteFiles()
        {
            if(_filePath == null || _fileName == null)
            {
                return false;
            }

            if(_filePath == "" || _fileName == "")
            {
                return false;
            }

            string[] files = Directory.GetFiles(_filePath);
            foreach (var file in files)
            {
                if (file.Contains(_fileName))
                {
                    DeleteFile(file);
                }
            }

            return true;
        }

        private void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }
    }
}
