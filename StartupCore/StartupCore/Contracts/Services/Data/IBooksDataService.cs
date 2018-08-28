using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using StartupCore.Models.BooksModels;
using System.Collections;

namespace StartupCore.Contracts.Services.Data
{
    public interface IBooksDataService
    {
        Task<IEnumerable<Booklist>> GetBooklists();
        Task<IEnumerable<CategoryContent>> GetCategories();
        Task<IEnumerable<Booklist>> GetBooksForCategory();
        Task<IEnumerable<Booklist>> WishedReadBooks();
        Task<IEnumerable<Booklist>> IAddThisBooks();
    }
}
