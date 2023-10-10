using cb_perform_test.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cb_perform_test.Services
{
    public interface IProductDetailService
    {
        Task<string> Set(ProductDetailWebModel productDetailWebModel);
        Task<ResultModel<List<ProductDetailWebModel>>> Get(string id);

        Task<ResultModel<List<ProductDetailWebModel>>> Test(ProductDetailWebModel productDetailWebModel);
    }
}
