using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AsyncHello.Models
{
    public class ApiViewModel
    {
        //[JsonProperty("user_Id")]
        public string UserId { get; set; }


        public string Id { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set; }
    }
}