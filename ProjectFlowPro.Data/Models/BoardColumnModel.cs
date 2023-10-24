namespace ProjectFlowPro.Data.Models
{
    public sealed record BoardColumnModel
    {
        public int ColumnId { get; set; }
        public required string StatusName { get; set; }
        public required string StatusDescription { get; set; }
        public required string StatusColor { get; set; }
        public int Position { get; set; }
    }
}
