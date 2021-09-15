using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureViewingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentViewer viewer = new DocumentViewer();
            string contents;

            Console.WriteLine("File1.txt");
            Console.WriteLine("---------");
            contents = viewer.GetDocumentContents(@"c:\courseware\file1.txt");
            Console.WriteLine(contents);
            Console.WriteLine();

            Console.WriteLine("File2.txt");
            Console.WriteLine("---------");
            contents = viewer.GetDocumentContents(@"c:\courseware\file2.txt");
            Console.WriteLine(contents);
            Console.WriteLine();

            Console.WriteLine("Hit any key to exit...");
            Console.Read();
        }
    }
}
