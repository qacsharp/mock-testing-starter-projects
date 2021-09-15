using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureViewingApp
{
    class RealFileReader : IFileReader
    {
        public string GetFileContents(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
