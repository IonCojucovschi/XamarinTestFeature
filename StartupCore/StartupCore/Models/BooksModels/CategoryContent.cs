using System;
namespace StartupCore.Models.BooksModels
{
    public class CategoryContent : ICategoryContent
    {
        public string category { get; set; }
        public string quantity { get; set; }
        public int id { get; set; }
    }
}
