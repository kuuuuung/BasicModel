using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicModel.Models;

namespace BasicModel.ViewModels
{
    public class BooksStore
    {
        IEnumerable<Book> lst;
        
        public BooksStore()
        {
            lst = new List<Book>
            {
                new Book {
                ISBN ="001",
                Title ="Book 1",
                Discription = "Discription for Book 1",
                Price = 200,
                picUrl = "~/img/book1.jpg"
            },
                new Book {
                ISBN ="002",
                Title ="Book 2",
                Discription ="Discription for Book 2",
                Price = 200,
                picUrl = "~/img/book2.jpg"
            },
                new Book {
                ISBN ="003",
                Title ="Book 3",
                Discription ="Discription for Book 3",
                Price = 200,
                picUrl = "~/img/book3.jpg"
            },
                new Book {
                ISBN ="004",
                Title ="Book 4",
                Discription ="Discription for Book 4",
                Price = 200,
                picUrl = "~/img/book4.jpg"
            }
            };
            
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return lst;
        }

        public Book GetBookById(string isbn)
        {
            return lst.First(i => i.ISBN == isbn);
        }
    }
 
}
