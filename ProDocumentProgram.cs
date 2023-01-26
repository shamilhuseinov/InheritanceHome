using System;
namespace Inheritance
{
    public class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in doc format, for pdf format buy Expert packet");
        }
    }


}

