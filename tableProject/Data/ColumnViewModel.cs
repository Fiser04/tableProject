using System.ComponentModel.DataAnnotations;

namespace tableProject.Contracts.ViewModels.Column;

public class ColumnViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}