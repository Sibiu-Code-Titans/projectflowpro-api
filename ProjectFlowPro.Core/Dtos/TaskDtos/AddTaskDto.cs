namespace ProjectFlowPro.Core.Dtos.TaskDtos
{
    public sealed record AddTaskDto
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime? Deadline { get; set; }
        public int ColumnId { get; set; }
    }
}
