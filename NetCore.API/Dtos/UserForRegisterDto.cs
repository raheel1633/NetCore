using System.ComponentModel.DataAnnotations;

namespace NetCore.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string username{get;set;}
        
        [Required]
        //[StringLength(8,MinimumLength=4,ErrorMessage="Password must at least 4 characters")]
        public string password{get;set;}

        public string email{get;set;}
    }
}