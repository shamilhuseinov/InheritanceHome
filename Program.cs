using System;
namespace Inheritance
{
    public class Program
    {

        static void Main()
        {
        Initial: var document = Console.ReadLine();

            if (document == "basic")
            {
                var basic = new DocumentProgram();
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
            }
            else if (document == "pro")
            {
                var pro = new ProDocumentProgram();
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if (document == "expert")
            {
                var expert = new ExpertDocumentProgram();
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }
            else
            {
                Console.WriteLine("try again");
            }
            goto Initial;
        }
    }
}
