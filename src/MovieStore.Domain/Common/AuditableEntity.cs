namespace MovieStore.Domain.Common;

public abstract class AuditableEntity
{
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;

    public string? CreatedBy { get; set; }

    public DateTimeOffset? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
