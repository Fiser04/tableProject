using System.Collections.Generic;

namespace tableProject.Models;

public class Table
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int ClientId { get; set; }

    public Client? Client { get; set; }
    public ICollection<Cell> Cells { get; set; } = new List<Cell>();
}