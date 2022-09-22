namespace Core.AddBookRead;

public interface IBookReadStore  
{  
    Task<bool> AddAsync(int userId, string isbn);  
}