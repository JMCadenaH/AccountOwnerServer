using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.AccountType.Equals("Savings"));
            // var owners = _repoWrapper.Owner.FindAll();
            ////_logger.LogInfo("Here is info message from our values controller.");
            ////_logger.LogDebug("Here is debug message from our values controller.");
            ////_logger.LogWarn("Here is warn message from our values controller.");
            ////_logger.LogError("Here is error message from our values controller.");

            return Ok(domesticAccounts); ;
        }
    }
}
