using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ChurchCashFlow.Data.Entities
{
    public class UserLogin
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
