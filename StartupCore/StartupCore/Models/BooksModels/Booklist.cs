using System;
namespace StartupCore.Models.BooksModels
{
    public class Booklist : IBooklist
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public string date { get; set; }
        public string publication_date { get; set; }
        public string description { get; set; }
        public string rating { get; set; }
        public string user_id { get; set; }
        public string downloands_number { get; set; }
        public string download_linq { get; set; }
        public string image_linq { get; set; }
    }
}
