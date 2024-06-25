using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker_YT.Models;

public class Category
{
    [Key] 
    public int CategoryId { get; set; }

    [Column(TypeName = "nvaechar(50")]
    public string Title { get; set; }

    [Column(TypeName = "nvaechar(5")] public string Icon { get; set; } = "";

    [Column(TypeName = "nvaechar(10")] public string Tyoe { get; set; } = "Expense";

}