using System;
using System.Collections.Generic;

namespace CSharpDesignPatterns.Creational.Factory2
{
    /// <summary>
    /// Abstract Page class for all page types to inherit from - polymorphic collection will be used
    /// </summary>
    abstract class Page
    {
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class ContentsPage : Page
    {
        
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class IntroductionPage : Page
    {
         
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class PreamblePage : Page
    {
        
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class CoverLetterPage : Page
    {
        
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class MainInfoPage : Page
    {
        
    }
    /// <summary>
    /// An example concrete Page class
    /// </summary>
    class CvPage : Page
    {
        
    }
    /// <summary>
    /// Abstract creator class
    /// </summary>
    abstract class DocumentCreator
    {
        private List<Page> _pages = new List<Page>();

        protected DocumentCreator()
        {
            CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreatePages();
    }
    /// <summary>
    /// Concrete creator class
    /// </summary>
    class ResumeCreator : DocumentCreator 
    {
        public override void CreatePages()
        {
            Pages.Add(new CoverLetterPage());
            Pages.Add(new CvPage());            
        }
    }
    /// <summary>
    /// Another concrete creator class
    /// </summary>
    class BookCreator : DocumentCreator
    {
        /// <summary>
        /// Overrides abstract createPages method to alter behaviour
        /// </summary>
        public override void CreatePages()
        {
            Pages.Add(new ContentsPage());
            Pages.Add(new IntroductionPage());
            Pages.Add(new PreamblePage()); // etc
        }
    }
    /// <summary>
    /// Tester class to show off the work
    /// </summary>
    class Tester
    {
        public Tester()
        {
            var docs = new DocumentCreator[2];

            docs[0] = new BookCreator();
            docs[1] = new ResumeCreator();

            foreach (DocumentCreator doc in docs)
            {
                Console.WriteLine("Document Type: " + doc.GetType().Name + Environment.NewLine);

                if (doc.Pages.Count > 0)
                {
                    Console.WriteLine("Pages:" + Environment.NewLine);
                    foreach (Page page in doc.Pages)
                    {
                        Console.WriteLine("- " + page.GetType().Name + Environment.NewLine);
                    }
                }
                
            }
            
        }
    }
}
