using cb_perform_test.Models;
using Couchbase.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cb_perform_test.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IClusterProvider _clusterProvider;
        private readonly IBucketProvider _bucketProvider;
        private readonly IConfiguration _configuration;
        public ProductDetailService(IClusterProvider clusterProvider, IBucketProvider bucketProvider, IConfiguration configuration = null)
        {
            _clusterProvider = clusterProvider;
            _bucketProvider = bucketProvider;
            _configuration = configuration;
        }

        public async Task<ResultModel<List<ProductDetailWebModel>>> Get(string id)
        {
            var cluster = await _clusterProvider.GetClusterAsync();

            var n1ql = $"SELECT d.* FROM {_configuration.GetValue<string>("Couchbase:BucketName")} d WHERE d.id = '{id}'";
            var result = await cluster.QueryAsync<ProductDetailWebModel>(n1ql, new Couchbase.Query.QueryOptions());
            var resultData = await result.Rows.ToListAsync();

            return resultData.Count() > 0 ?
                new ResultModel<List<ProductDetailWebModel>> { data = resultData, status = 1 } :
                new ResultModel<List<ProductDetailWebModel>> { data = null, status = 0 };

        }

        public async Task<string> Set(ProductDetailWebModel product)
        {
            var bucket = await _bucketProvider.GetBucketAsync(_configuration.GetValue<string>("Couchbase:BucketName"));
            var collection = bucket.DefaultCollection();

            var key = Guid.NewGuid().ToString();
            await collection.InsertAsync(key, product);
            return "Inserted user with ID: " + key;
        }

        public async Task<ResultModel<List<ProductDetailWebModel>>> Test(ProductDetailWebModel productDetailWebModel)
        {
            var get = await Get(productDetailWebModel.Id.ToString());

            if (get.status != 0)
            {
                return get;
            }   

            await Set(productDetailWebModel);

            var productList = new List<ProductDetailWebModel>();

            productList.Add(productDetailWebModel);

            return new ResultModel<List<ProductDetailWebModel>> { data = productList, status = 1 };
        }
    }
}
