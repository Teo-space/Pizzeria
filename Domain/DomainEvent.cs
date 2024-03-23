namespace Domain;

public record DomainEvent
{
    public required Guid EventId { get; init; } = Ulid.NewUlid().ToGuid();

    public required DateTime Date { get; init; }

}
