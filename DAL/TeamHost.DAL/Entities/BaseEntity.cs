namespace TeamHost.DAL.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
