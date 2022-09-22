namespace Core.AddBookRead;

public interface IAddBookRead  
{  
    Task<bool> AddReadAsync(int userId, string isbn);  
}