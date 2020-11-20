using _14_Models_in_Asp.net_Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _14_Models_in_Asp.net_Core.Repositores
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);
        //string GetAppName();
    }
}