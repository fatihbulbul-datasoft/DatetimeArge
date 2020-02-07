using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;

namespace DatetimeArge.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluateController : ControllerBase {
        // POST api/values
        [HttpPost]
        public Task<object> Post([FromBody] string value) {
            return CSharpScript.EvaluateAsync(value);
        }

    }
}
