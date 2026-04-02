using System.Collections.Generic;

namespace tableProject.Models;

public class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public ICollection<Table> Tables { get; set; } = new List<Table>();
}