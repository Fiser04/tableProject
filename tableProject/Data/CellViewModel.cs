namespace tableProject.Contracts.ViewModels.Cell;

public class CellViewModel
{
    public int Id { get; set; }
    public string? Value { get; set; }
    public int TableId { get; set; }
    public int ColumnId { get; set; }
    public int RowId { get; set; }
}