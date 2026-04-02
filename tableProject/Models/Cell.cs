namespace tableProject.Models;

public class Cell
{
    public int Id { get; set; }
    public string? Value { get; set; }

    public int TableId { get; set; }
    public Table? Table { get; set; }

    public int ColumnId { get; set; }
    public Column? Column { get; set; }

    public int RowId { get; set; }
    public Row? Row { get; set; }
}