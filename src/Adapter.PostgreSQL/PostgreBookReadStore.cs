using Core.AddBookRead;

namespace Adapter.PostgreSQL;
public class PostgreBookReadStore : IBookReadStore
{
    public Task<bool> AddAsync(int userId, string isbn)
    {
        throw new NotImplementedException();
    }
}
