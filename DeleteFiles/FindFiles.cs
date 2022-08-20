using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            string[] files;
            try
            {
                 files= Directory.GetFiles(_filePath);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                return false;
            }

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
