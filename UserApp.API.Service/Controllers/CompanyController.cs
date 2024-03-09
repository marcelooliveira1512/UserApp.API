using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserApp.API.Service.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        /// <summary>
        /// Criar conta para uma Nova Empresa
        /// </summary>
        [Route("add")]
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        /// <summary>
        /// Editar a conta de uma Empresa
        /// </summary>
        [Route("edit")]
        [HttpPut]
        public IActionResult Edit()
        {
            return Ok();
        }

        /// <summary>
        /// Excluir a conta de uma Empresa
        /// </summary>
        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados de uma Empresa
        /// </summary>
        [Route("get")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
