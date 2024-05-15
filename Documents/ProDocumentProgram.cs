using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument() => Console.WriteLine("Document Edited");

        public override void SaveDocument(string format)
        {
            if (format == "doc") Console.WriteLine("Saved in doc format");
            else if (format == "pdf") Console.WriteLine("Saved in doc format, for pdf buy Expert packet");
            else Console.WriteLine("Invaild format");
        }
    }
}
