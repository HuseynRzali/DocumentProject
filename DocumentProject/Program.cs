using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DocumentProject
{

    abstract class DocumentProgram
    {

        public string Document { get; set; }

        public virtual void Open()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Document Opened ");
            Console.ResetColor();
        }
        public virtual void Edit()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Can Edit in Pro and Expert versions ");
            Console.ResetColor();
        }
        public virtual void Save()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Can Save in Pro and Expert versions ");
            Console.ResetColor();
        }

    }

    class ProDocumentProgram : DocumentProgram
    {


        public override void Open()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Document Opened");
            Console.ResetColor();
        }
        public sealed override void Edit()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Document Edited with sealed method ");
            Console.ResetColor();
        }

        public override void Save()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Document Saved in doc format, for pdf format buy Expert packet ");
            Console.ResetColor();
        }

    }

    class ExpertDocumentProgram : ProDocumentProgram
    {

        public override void Open()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Expert Document Opened");
            Console.ResetColor();
        }

        public override void Save()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Expert Document Saved in .pdf format");
            Console.ResetColor();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentProgram basic = new ProDocumentProgram();
            ProDocumentProgram pro = new ProDocumentProgram();
            ExpertDocumentProgram expert = new ExpertDocumentProgram();
            pro.Save();
            basic.Edit();
            expert.Open();


        }
    }
}


