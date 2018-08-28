using System;
namespace StartupCore.Constants
{
    public class ApiConstants
    {
        public const string BaseApi = "http://readabook.16mb.com/";
        public const string PostLogin = "api/users/all/";
        public const string PostSetTokenDevice = "api/client/auth/set_token";

        ///books get
        public const string GetBooksCategory = "api/allcategory";
        public const string GetBooksForCategory = "api/books/category";
        public const string GetWishedBook = "api/wishedbook/id";
        public const string GetAddedBook = "api/iaddthis/id";

    }
}
