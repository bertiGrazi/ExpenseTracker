using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker_YT.Models;

public class Category
{
    [Key] 
    public int CategoryId { get; set; }
}