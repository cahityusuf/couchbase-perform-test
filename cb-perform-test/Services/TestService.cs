using cb_perform_test.Models;
using Couchbase.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cb_perform_test.Services
{
    public class TestService<T> : ITestService<T>
    {
        private readonly IClusterProvider _clusterProvider;
        private readonly IBucketProvider _bucketProvider;

        public TestService(IClusterProvider clusterProvider, IBucketProvider bucketProvider)
        {
            _clusterProvider = clusterProvider;
            _bucketProvider = bucketProvider;
        }

        public async Task<List<User>> GetUserByEmail(string email)
        {
            var cluster = await _clusterProvider.GetClusterAsync();

            var n1ql = $"SELECT d.* FROM DeFacto d WHERE d.email = '{email}'";
            var result = await cluster.QueryAsync<User>(n1ql, new Couchbase.Query.QueryOptions());

            return await result.Rows.ToListAsync();
        }

        public async Task<string> InsertUser(User user)
        {
            var bucket = await _bucketProvider.GetBucketAsync("DeFacto");
            var collection = bucket.DefaultCollection();

            var key = Guid.NewGuid().ToString();
            await collection.InsertAsync(key, user);
            return "Inserted user with ID: " + key;
        }
    }
}
