using MediatR;

namespace Ordering.Domain.Abstractions;

public interface IDomainEvent : INotification
{
    Guid EventId => Guid.NewGuid();
    public DateTime OccurredOn => DateTime.UtcNow;
    public DateTime OccurredOnLocalDate => DateTime.UtcNow.AddHours(-5);
    public string EventType => GetType().AssemblyQualifiedName!;
}