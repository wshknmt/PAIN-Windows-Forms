using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN
{
    public class Book
    {
        public string Title
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public Book(string title, string author, DateTime releaseDate, string category)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Category = category;
        }
    }
}
