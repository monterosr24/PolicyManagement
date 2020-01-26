using System.Web.Http;
using PolicyManagement.Controllers.Api;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;

namespace PolicyManagement.Controllers.api
{
    public class PolicyController : BaseApiController<Policy, PolicyViewModel, IPolicyService>
    {
        public PolicyController()
        {

        }

        public override IHttpActionResult Post([FromBody] PolicyViewModel entityModel)
        {
            var result = base.Post(entityModel);

            if (result == null)
            {
                return BadRequest("La poliza no cumple con la regla de negocio, no puede ser de riesgo alto con un porcentaje mayor al 50%");
            }

            return result;
        }
    }
}