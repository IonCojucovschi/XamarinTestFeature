using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace StartupCore.Models
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }

        [JsonProperty("surname")]
        public string FirstName { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("login")]
        public string login { get; set; }

        [JsonProperty("pasword")]
        public string password { get; set; }

        [JsonProperty("active")]
        public int active { get; set; }
    }
}
