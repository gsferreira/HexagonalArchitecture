namespace Core.AddBookRead;

public interface IBookReadPublisher  
{  
    Task<bool> PublishAsync(int userId, string isbn);  
}