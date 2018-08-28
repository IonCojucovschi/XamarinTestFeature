﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akavache;
using StartupCore.Models.BooksModels;

namespace StartupCore.Contracts.Services.Data
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
