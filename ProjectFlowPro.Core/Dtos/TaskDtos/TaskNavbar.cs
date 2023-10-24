namespace ProjectFlowPro.Core.Dtos.TaskDtos
{
    public sealed record TaskNavbar
    {
        public string Title { get; set; }
        public required string StatusName { get; set; }
    }
}
