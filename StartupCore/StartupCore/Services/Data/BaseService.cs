﻿using System.Threading.Tasks;
using Akavache;
using System.Reactive.Linq;
using StartupCore.Models.BooksModels;
using System.Collections.Generic;

namespace StartupCore.Services.Data
{
    public class BaseService
    {
        protected IBlobCache Cache;

        public BaseService(IBlobCache cache)
        {
            Cache = cache ?? BlobCache.LocalMachine;
        }

        public async Task<T> GetFromCache<T>(string cacheName)
        {
            try
            {
                T t = await Cache.GetObject<T>(cacheName);

                return t;
            }
            catch (KeyNotFoundException)
            {
                return default(T);
            }
        }

        public void InvalidateCache()
        {
            Cache.InvalidateAllObjects<Booklist>();
        }
    }
}
