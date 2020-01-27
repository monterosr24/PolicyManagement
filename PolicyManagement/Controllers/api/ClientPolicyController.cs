using PolicyManagement.Controllers.Api;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace PolicyManagement.Controllers.api
{
    [RoutePrefix("api")]
    public class ClientPolicyController : BaseApiController<ClientPolicy, ClientPolicyViewModel, IClientPolicyService>
    {
        [HttpPost]
        [Route("ClientPolicy/List")]
        public IHttpActionResult List([FromBody]List<ClientPolicyViewModel> entityModels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }

            entityModels.ForEach(entityModel =>
            {
                base.Post(entityModel);
            });


            return Ok();
        }
    }
}