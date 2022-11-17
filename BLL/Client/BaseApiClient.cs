using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6SpaTemplate.BLL.Client
{
    public class BaseApiClient
    {
        protected readonly string BaseUrl;

        protected BaseApiClient(FoodApiConfig config)
        {
            BaseUrl = config.BaseUrl;
        }
    }
}
