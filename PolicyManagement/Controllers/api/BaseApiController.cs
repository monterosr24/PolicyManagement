using PolicyManagement.Models.Model;
using PolicyManagement.Services.Interface;
using PolicyManagement.Utilis;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Http.Results;

namespace PolicyManagement.Controllers.Api
{
    public abstract class BaseApiController<TEntity, TEntityModel, TService> : ApiController
        where TEntity: BaseModel
        where TService: IBaseService<TEntityModel>
    {
        private readonly DbContext _context;
        private readonly TService _service;

        public BaseApiController()
        {
            _context = DependencyInjection.GetInstanceOf<DbContext>();
            _service = DependencyInjection.GetInstanceOf<TService>();
        }
        
        protected override OkResult Ok()
        {
            return new OkJsonPathResult(this);
        }

        public virtual IHttpActionResult Get([FromUri]int id)
        {
            var result = _service.GetId(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        public virtual IHttpActionResult Get()
        {
            var result = _service.GetAll();
            return Ok(result);
        }

        public virtual IHttpActionResult Post([FromBody]TEntityModel entityModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }

            var result = _service.Create(entityModel, "test");

            return Created("", result);
        }

        public virtual IHttpActionResult Put([FromUri]int id, [FromBody]TEntityModel entityModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }

            var result = _service.Update(id, entityModel, "");
            return Ok(result);
        }

        public virtual IHttpActionResult Delete([FromUri]int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}