using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace tableProject.Models;

public class Column
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public ICollection<Cell> Cells { get; set; } = new List<Cell>();
}