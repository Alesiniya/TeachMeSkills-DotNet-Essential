using System;

namespace TeachMeSkills.DotNet.Task11
{
    public class DocumentWorker
    {
        public DocumentWorker()
        {
            Console.WriteLine("-----");
            Console.WriteLine("DocumentWorker created.");
        }
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document open.");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Edit Document is available in PRO version.");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Save Document is available in PRO version.");
        }
    }
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker()
        {
            Console.WriteLine("-----");
            Console.WriteLine("ProDocumentWorker created.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format. " +
                "New format is available in Expert version"); ;
        }
        public override void EditDocument()
        {
            Console.WriteLine("Document have been edited."); ;
        }
    }
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker()
        {
            Console.WriteLine("-----");
            Console.WriteLine("ExpertDocumentWorker created.");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in new format."); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter key (PRO - 1, EXP - 2, Default - 0) : ");
            int key = Int32.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                    proDocumentWorker.OpenDocument();
                    proDocumentWorker.EditDocument();
                    proDocumentWorker.SaveDocument();
                    break;
                case 2:
                    ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                    expertDocumentWorker.OpenDocument();
                    expertDocumentWorker.EditDocument();
                    expertDocumentWorker.SaveDocument();
                    break;
                default:
                    DocumentWorker documentWorker = new DocumentWorker();
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                    break;
            }
        }
    }
}
