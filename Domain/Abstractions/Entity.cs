namespace Domain.Abstractions
{
    public abstract class Entity<T> : IEntity<T>
    {
        public required T Id { get; set; }
    }
}
