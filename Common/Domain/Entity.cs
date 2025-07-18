using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

/// <summary>
/// Базовая доменная сущность
/// </summary>
public abstract record Entity
{
    //Список событий для хранения
    [NotMapped]
    private List<LogEvent> logEvents { get; } = new List<LogEvent>();
    [NotMapped]
    public IReadOnlyCollection<LogEvent> LogEvents => logEvents;

    public void AddLogevent(LogEvent e) => logEvents.Add(e);



    //Список доменных событий
    [NotMapped]
    private List<DomainEvent> domainEvents { get; } = new List<DomainEvent>();
    [NotMapped]
    public IReadOnlyCollection<DomainEvent> DomainEvents => domainEvents;

    public void AddDomainEvent(DomainEvent e) => domainEvents.Add(e);

}

