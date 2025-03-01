using Domain.Exceptions;

namespace Domain.ValueObjects
{
    public record TopicId
    {
        public Guid Value { get; }

        private TopicId(Guid value)
        {
            this.Value = value;
        }

        public static TopicId Of(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new DomainException("TopicId не может быть пустым.");
            }
            return new TopicId(value);
        }
    }
}