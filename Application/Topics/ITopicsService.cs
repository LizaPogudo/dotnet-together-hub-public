using Domain.ValueObjects;

namespace Application.Topics
{
    public interface ITopicsService
    {
        Task<IEnumerable<Topic>> GetTopicsAsync();
        Task<Topic> GetTopicAsync(Guid id);
        Task<Topic> CreateTopicAsync(Topic topicRequestDto);
        Task<Topic> UpdateTopicAsync(TopicId id, Topic topicRequestDto);
        Task DeleteTopicAsync(TopicId id);
    }
}
