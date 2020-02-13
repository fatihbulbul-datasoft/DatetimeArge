using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Threading.Tasks;

namespace DatetimeArge.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluateController : ControllerBase {
        // POST api/values
        [HttpPost]
        public Task<object> Post([FromBody] string value) {
            try {
                return CSharpScript.EvaluateAsync(value);
            } catch (Exception ex) {
                return Task.FromResult((object)ex.Message);
            }
        }
    }
}
