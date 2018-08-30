using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StartupCore.Contracts.Services.Data;
using StartupCore.Models.BooksModels;
using StartupCore.Constants;
using StartupCore.Contracts.Repository;
using Akavache;
using System.Reactive.Linq;

namespace StartupCore.Services.Data
{
    public class BooksDataService : BaseService, IBooksDataService
    {
        private readonly IGenericRepository _genericRepository;

        public BooksDataService(IGenericRepository genericRepository, IBlobCache cache = null) : base(cache)
        {
            _genericRepository = genericRepository;
        }


        public Task<IEnumerable<Booklist>> GetBooklists()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Booklist>> GetBooksForCategory()
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.GetBooksForCategory
            };

            var books = await _genericRepository.GetAsync<BooksResponse<Booklist>>(builder.ToString());

            ///await Cache.InsertObject(CacheNameConstants.AllPies, pies, DateTimeOffset.Now.AddSeconds(20));

            return books.data;
        }

        public async Task<IEnumerable<CategoryContent>> GetCategories()
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.GetBooksCategory
            };

            var categories = await _genericRepository.GetAsync<BooksResponse<CategoryContent>>(builder.ToString());

            ///await Cache.InsertObject(CacheNameConstants.AllPies, pies, DateTimeOffset.Now.AddSeconds(20));

            return categories.data;
        }

        public async Task<IEnumerable<Booklist>> IAddThisBooks()
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.GetAddedBook
            };

            var books = await _genericRepository.GetAsync<BooksResponse<Booklist>>(builder.ToString());

            await Cache.InsertObject(CacheNameConstants.AllBooks, books, DateTimeOffset.Now.AddSeconds(20));

            return books.data;
        }

        public async Task<IEnumerable<Booklist>> WishedReadBooks()
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseApi)
            {
                Path = ApiConstants.GetWishedBook
            };

            var books = await _genericRepository.GetAsync<BooksResponse<Booklist>>(builder.ToString());

            await Cache.InsertObject(CacheNameConstants.AddedBooks, books, DateTimeOffset.Now.AddSeconds(20));

            return books.data;
        }
    }
}
