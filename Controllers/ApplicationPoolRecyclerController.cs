using System.Web.Http;
using PagesJaunesResto.ApplicationPoolManager.Core;

namespace PagesJaunesResto.ApplicationPoolManager.Api.Controllers
{
    public class ApplicationPoolRecyclerController : ApiController
    {
        private readonly IApplicationPoolManger _applicationPoolManger;

        public ApplicationPoolRecyclerController()
        {
            _applicationPoolManger = new Core.ApplicationPoolManager();
        }

        public bool Put(string applicationPoolName)
        {
            return _applicationPoolManger.Recycle(applicationPoolName);
        }
    }
}