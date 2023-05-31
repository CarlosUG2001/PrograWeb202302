using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private ICategoryDAL categoryDAL;

        #region Constructores

        public CategoryController()
        {

        }

        #endregion
        #region Consultas

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        #endregion
        #region Agregar

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        #endregion
        #region Modificar

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        #endregion
        #region Eliminar

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        #endregion

    }
}
