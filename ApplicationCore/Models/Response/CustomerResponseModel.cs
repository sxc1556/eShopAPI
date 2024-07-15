using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Models.Response;

public class CustomerResponseModel
{
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }
    [Column(TypeName = "varchar(50)")]
    [Required]
    public string LastName { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string Gender { get; set; }
    [Column(TypeName = "varchar(10)")]
    public string Phone { get; set; }
}