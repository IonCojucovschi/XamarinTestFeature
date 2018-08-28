using System;
using System.Collections.Generic;

namespace StartupCore.Models.BooksModels
{
    public class BooksResponse<T> where T : class
    {
        public List<T> data { get; set; }
    }
}
