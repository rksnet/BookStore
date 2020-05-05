using RksNet.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RksNet.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(b => b.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string author)
        {
            return DataSource().Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) || b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id = 1, Title = "MVC", Author = "Rupesh"},
                new BookModel(){ Id = 2, Title = "CSharp", Author = "Paras"},
                new BookModel(){ Id = 3, Title = "DotNET", Author = "Neha"},
                new BookModel(){ Id = 4, Title = "Angular", Author = "Suman"},
                new BookModel(){ Id = 5, Title = "React", Author = "Verma"},
                new BookModel(){ Id = 6, Title = "Javascript", Author = "Rupesh"}
            };
        }
    }
}
