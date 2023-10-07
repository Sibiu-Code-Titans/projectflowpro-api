namespace ProjectFlowPro.Data.Models.TaskModels
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime UpdatedDatetime { get; set; }
        public DateTime? Deadline { get; set; }
        public int ColumnId { get; set; }
    }
}
