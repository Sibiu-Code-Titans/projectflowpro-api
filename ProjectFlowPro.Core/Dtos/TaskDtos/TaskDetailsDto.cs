namespace ProjectFlowPro.Core.Dtos.TaskDtos
{
    public class TaskDetailsDto
    {
        public String TaskId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime UpdatedDatetime { get; set; }
        public DateTime? Deadline { get; set; }
        public int ColumnId { get; set; }
        public int RemainingDays { get; set; }
        public int Progress { get; set; }
    }
}
