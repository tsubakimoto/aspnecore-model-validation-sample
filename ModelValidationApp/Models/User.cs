using Microsoft.AspNetCore.Mvc;

namespace ModelValidationApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Remote(action: "VerifyName", controller: "Users")]
        public string Name { get; set; }

        public int Gender { get; set; }
    }
}
