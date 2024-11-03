namespace Domain;


public record LogEvent
{
    public required Guid EventId { get; init; } = Ulid.NewUlid().ToGuid();

    public required DateTime Date { get; init; }

    public required Guid EntityId { get; init; }
    public required string EntityType { get; init; }

    public required string EventType { get; init; }
}
