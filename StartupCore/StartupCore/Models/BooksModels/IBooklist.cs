using System;
namespace StartupCore.Models.BooksModels
{
    public interface IBooklist : IEntity
    {
        string title { get; set; }
        string author { get; set; }
        string category { get; set; }
        string date { get; set; }
        string publication_date { get; set; }
        string description { get; set; }
        string rating { get; set; }
        string user_id { get; set; }
        string downloands_number { get; set; }
        string download_linq { get; set; }
        string image_linq { get; set; }
    }
}
