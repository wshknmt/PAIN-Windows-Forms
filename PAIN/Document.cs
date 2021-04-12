using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN
{
    public class Document
    {
        public List<Book> books = new List<Book>();
        public int mdiChildrenCounter = 0;

        public event Action<Book> AddBookEvent;
        public event Action<Book> EditBookEvent;
        public event Action<Book> DeleteBookEvent;
        
        public void AddBook(Book book)
        {
            books.Add(book);
            AddBookEvent?.Invoke(book);
        }

        public void EditBook(Book book)
        {
            EditBookEvent?.Invoke(book);
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
            DeleteBookEvent?.Invoke(book);
        }


    }

    
}
