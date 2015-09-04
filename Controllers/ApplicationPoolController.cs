using System.Collections.Generic;
using System.Web.Http;
using PagesJaunesResto.ApplicationPoolManager.Core;
using PagesJaunesResto.ApplicationPoolManager.Core.Models;

namespace PagesJaunesResto.ApplicationPoolManager.Api.Controllers
{
    public class ApplicationPoolController : ApiController
    {
        private readonly IApplicationPoolManger _applicationPoolManger;
        public ApplicationPoolController()
        {
            _applicationPoolManger = new Core.ApplicationPoolManager();
        }

        public IEnumerable<ApplicationPoolDescription> Get()
        {
            return _applicationPoolManger.ListPools();
        }
    }
}