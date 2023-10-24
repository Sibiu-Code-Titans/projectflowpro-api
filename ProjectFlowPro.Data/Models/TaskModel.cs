using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFlowPro.Data.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public DateTime UpdatedDatetime { get; set; }
        public DateTime? Deadline { get; set; }
        public int ColumnId { get; set; }
        public BoardColumnModel BoardColumn { get; set; }
    }
}
