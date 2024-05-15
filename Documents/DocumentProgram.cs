using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can edit in pro and expert version");
        }

        public virtual void SaveDocument(string format)
        {
            Console.WriteLine("Can edit in pro and expert version");
        }
    }
}
