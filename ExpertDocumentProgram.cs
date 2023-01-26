using System;
namespace Inheritance
{
    public class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in pdf format");
        }
    }
}

