using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
     class Poem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateCreation { get; set; }
        public string VerseText { get; set; }
        public string VerseTheme { get; set; }
        
        public Poem() { }
        public Poem(string name, string author, DateTime dateCreation, string verseText, string vesseTheme)
        {
            Name = name;
            Author = author;
            DateCreation = dateCreation;
            VerseText = verseText;
            VerseTheme = vesseTheme;
        }
    }
}
