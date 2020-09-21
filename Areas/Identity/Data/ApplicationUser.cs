using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace IntroIdentity.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
    }
}