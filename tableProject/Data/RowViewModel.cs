using System.ComponentModel.DataAnnotations;

namespace tableProject.Contracts.ViewModels.Row;

public class RowViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}