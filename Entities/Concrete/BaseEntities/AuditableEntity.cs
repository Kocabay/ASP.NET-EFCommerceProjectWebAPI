using Entities.Abstract;



namespace Entities.Concrete.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity, IUpdatedEntity
    {
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
