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
                new BookModel(){ Id = 1, Title = "MVC", Author = "Rupesh", Description = "This is MVC book for Dev people", Category="Programming", Language="English", TotalPages = 100},
                new BookModel(){ Id = 2, Title = "CSharp", Author = "Paras", Description = "This is CSharp book for Dev people", Category="Framework", Language="English", TotalPages = 200},
                new BookModel(){ Id = 3, Title = "DotNET", Author = "Neha", Description = "This is DotNet book for Dev people", Category="Microsoft", Language="Chinees", TotalPages = 123},
                new BookModel(){ Id = 4, Title = "Angular", Author = "Suman", Description = "This is Angular book for Dev people", Category="Javascript", Language="English", TotalPages = 143},
                new BookModel(){ Id = 5, Title = "React", Author = "Verma", Description = "This is ReactJS book for Dev people", Category="Programming", Language="French", TotalPages = 187},
                new BookModel(){ Id = 6, Title = "Javascript", Author = "Rupesh", Description = "This is Javascript book for Dev people", Category="Javascript", Language="English", TotalPages = 133}
            };
        }
    }
}
