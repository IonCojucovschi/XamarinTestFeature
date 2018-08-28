using System;
namespace StartupCore.Models.BooksModels
{
    public interface ICategoryContent : IEntity
    {
        string category { get; set; }
        string quantity { get; set; }
    }
}
