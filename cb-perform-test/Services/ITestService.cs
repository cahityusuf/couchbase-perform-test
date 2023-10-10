using cb_perform_test.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cb_perform_test.Services
{
    public interface ITestService<T>
    {
        Task<string> InsertUser(User user);
        Task<List<User>> GetUserByEmail(string email);
    }
}
