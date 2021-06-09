using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommonEmployeeAPI.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(75)")]
        public string EmailId { get; set; }

        [Column(TypeName = "char(1)")]
        public string Gender { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Location { get; set; }

        [Column(TypeName = "varchar(512)")]
        public string Remarks { get; set; }

        [Column(TypeName = "int")]
        public int Age { get; set; }

        [Column(TypeName = "Datetime")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Status { get; set; }

    }
}
