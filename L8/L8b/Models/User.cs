using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L8b.Models;

public class User
{
    /// <summary>
    /// User id
    /// </summary>
    /// <example>101</example>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    /// <summary>
    /// User lastname
    /// </summary>
    /// <example>Smith</example>
    public string lastname { get; set; }
    /// <summary>
    /// User firstname
    /// </summary>
    /// <example>Adam</example>
    public string firstname { get; set; }
    /// <summary>
    /// User email
    /// </summary>
    /// <example>xxx@yyy.com</example>
    [Required]
    [EmailAddress]
    public string email { get; set; }
    /// <summary>
    /// User password
    /// </summary>
    /// <example>Pa$$w0rd</example>
    [Required]
    public string password { get; set; }
    /// <summary>
    /// User status
    /// </summary>
    /// <example>active</example>
    [Required]
    public string status { get; set; }
    /// <summary>
    /// User role
    /// </summary>
    /// <example>customer</example>
    [Required]
    public string role { get; set; }
}