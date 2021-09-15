using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureViewingApp
{
    public class DocumentViewer
    {
        private readonly IFileReader fileReader;
        private readonly IUserIdentifier userIdentifier;

        public DocumentViewer()
        {
            this.fileReader = new RealFileReader();
            this.userIdentifier = new RealUserIdentifier();
        }

        public DocumentViewer(IFileReader fileReader, IUserIdentifier userIdentifier)
        {
            this.fileReader = fileReader;
            this.userIdentifier = userIdentifier;
        }

        public string GetDocumentContents(string filename)
        {
            string contents = fileReader.GetFileContents(filename);
            string userLogonName = userIdentifier.GetLoggedOnUsername();

            bool contentsAreSecret = (contents.StartsWith("SECRET"));
            bool userAllowedToViewSecretFile = (userLogonName.ToUpper().Contains("X"));

            if (contentsAreSecret == false)
                return contents;
            else if (userAllowedToViewSecretFile == true)
                return contents;
            else
                return $"You ({userLogonName}) do not have permission to view the contents of the file.";
        }
    }
}
