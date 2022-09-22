using Core.AddBookRead;

namespace Adapter.Kafka;

public class KafkaBookReadPublisher : IBookReadPublisher
{
    public Task<bool> PublishAsync(int userId, string isbn)
    {
        throw new NotImplementedException();
    }
}
