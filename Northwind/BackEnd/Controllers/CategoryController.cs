using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            categoryDAL = new CategoryDALImpl();
        }

        #endregion
        #region Consultas

        [HttpGet]
        public JsonResult Get()
        {

            IEnumerable<Category> categories = categoryDAL.GetAll();

            return new JsonResult(categories);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {

            Category category = categoryDAL.Get(id);
            return new JsonResult(category);

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
